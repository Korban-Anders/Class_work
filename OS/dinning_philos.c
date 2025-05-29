#include <stdlib.h>
#include <time.h>
#include <stdio.h>
#include <pthread.h>
#include <unistd.h>



#define PHILOS_NUM 5
#define MAX_MEALS 10
#define MAX_THINK_EAT_SEC 4.0
#define LEFT (philo_id + 4) % PHILOS_NUM
#define RIGHT (philo_id + 1) % PHILOS_NUM


enum { THINKING, HUNGRY, EATING} state[PHILOS_NUM]; 

pthread_mutex_t mutex;
pthread_cond_t condition[PHILOS_NUM];
int meals[PHILOS_NUM] = {0};
int run_timeout = 0;


void *philo_run(void *param);
void pickup(int philo_id);
void putdown(int philo_id);
void test(int philo_id);
void sleep_double();

int main(int argc, char *argv[]) {
    // Checks that there is a 2nd argv and errors out if there isnt
    if (argc != 2) {
        fprintf(stderr, "Usage: %s <run_time>\n", argv[0]);
        return 1;
    }

    // random num generator
    srand(time(NULL));
    // grabs the 2nd argv which is the run_time and converts to int
    int run_time = atoi(argv[1]);
    // array of pthreads that hold the philosophers
    pthread_t philosophers[PHILOS_NUM];
    // array of philosophers' id
    int philo_ids[PHILOS_NUM];


    // initializes the mutex
    pthread_mutex_init(&mutex, NULL);
    for (int i = 0; i < PHILOS_NUM; i++) {
        // initalizes philosopher condition var
        pthread_cond_init(&condition[i], NULL);
    }

    
    for (int i = 0; i < PHILOS_NUM; i++) {
        // initlize ids
        philo_ids[i] = i;
        // creates each pholospher thread
        // runs philo_run 
        pthread_create(&philosophers[i], NULL, philo_run, &philo_ids[i]);
    }

    // sleeps for run_time
    sleep(run_time);

    run_timeout = 1;

    pthread_mutex_lock(&mutex);
    for (int i = 0; i < PHILOS_NUM; i++) {
        pthread_cond_signal(&condition[i]);
    }
    pthread_mutex_unlock(&mutex);


    for (int i = 0; i < PHILOS_NUM; i++) {
        // joins all threads when main loop is done
        pthread_join(philosophers[i], NULL);
    }

    // destroys mutex for mem safety
    pthread_mutex_destroy(&mutex);
    for (int i = 0; i < PHILOS_NUM; i++){
        // destroys mutex for mem safety
        pthread_cond_destroy(&condition[i]);
    }

    // table data
    printf("\nMeals eaten by each philosopher:\n");
    int min_meals = MAX_MEALS, max_meals = 0, total_meals = 0;
    for (int i = 0; i < PHILOS_NUM; i++) {
        printf("Philosopher %d: %d meals\n", i, meals[i]);
        if (meals[i] < min_meals){
            min_meals = meals[i];
        }
        if (meals[i] > max_meals){
            max_meals = meals[i];
        }
        total_meals += meals[i];
    }
    printf("Min: %d, Max: %d, Avg: %.2f\n", min_meals, max_meals, total_meals / (double)PHILOS_NUM);
    return 0;
}

void *philo_run(void *param) {
    // gets philosophers id
    int philo_id = *(int *)param;
    while (!run_timeout && meals[philo_id] < MAX_MEALS) {
        // philosopher THINKS for a rand time from 1 to 4
        sleep_double();
        // call pickup
        pickup(philo_id);
        // philosopher EATS for a rand time from 1 to 4
        sleep_double();
        // calls putdown
        putdown(philo_id);
    }
    // thread exits
    return NULL;
}

void pickup(int philo_id) {
    // locks mutex to ensure mutual exclusion
    pthread_mutex_lock(&mutex);
    // sets philosopher to HUNGRY 
    state[philo_id] = HUNGRY;
    printf("Philosopher %d is HUNGRY\n", philo_id);
    // calls test 
    test(philo_id);
    while (state[philo_id] != EATING){
        // makes HUNGRY philosopher wait for open space
        pthread_cond_wait(&condition[philo_id], &mutex);
    }
    // unlocks mutex so next philosopher can be called
    pthread_mutex_unlock(&mutex);
}

void putdown(int philo_id) {
    // locks mutex to ensure mutual exclusion
    pthread_mutex_lock(&mutex);
    // set philosopher to THINKING
    state[philo_id] = THINKING;
    printf("Philosopher %d puts down chopsticks and starts THINKING\n", philo_id);
    // allows left and right neighbors to eat if their conditions are met
    test(LEFT);
    test(RIGHT);
    // unlocks mutex so next philosopher can be called
    pthread_mutex_unlock(&mutex);
}

void test(int philo_id) {
    if (state[philo_id] == HUNGRY && state[LEFT] != EATING && state[RIGHT] != EATING) {
        // sets philosopher to eating if left and right are not eating
        state[philo_id] = EATING;
        printf("Philosopher %d starts EATING\n", philo_id);
        meals[philo_id]++;
        // will signal to waiting philosophers in pickup
        pthread_cond_signal(&condition[philo_id]);
    }
}

void sleep_double(){
    double delay = 1.0 + ((double)rand() / RAND_MAX) * (MAX_THINK_EAT_SEC - 1.0);

    struct timespec req;
    req.tv_sec = (time_t)delay;
    req.tv_nsec= (long)((delay - req.tv_sec) * 1000000000L);

    nanosleep(&req, NULL);
}