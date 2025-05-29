/* File: primes.c */
/* Author: Britton Wolfe */
/* Date: July 16, 2009 */
/* This program outputs all the primes in the range given */
/* by the command line arguments */

#include <stdlib.h>
#include <stdio.h>
#include <math.h>

int main(int argc, const char** argv){

    int lowerBound, upperBound;

    if(argc != 3){
        fprintf(stderr, "USAGE: %s lowerBound upperBound\n", argv[0]);
        return -1;
    }
  
    lowerBound = atoi(argv[1]);
    upperBound = atoi(argv[2]);
  
    if(lowerBound < 1 || upperBound < 1){
        fprintf(stderr, "ERROR: both the lowerBound (%d) and the upperBound (%d)"
	          " must be positive.\n", lowerBound, upperBound);
        return -2;
    }
  
    {
        /* TODO: fill in the code that outputs the prime numbers */
        /*   in the range [lowerBound,upperBound] in ascending order */
        for(int i = lowerBound; i <= upperBound; i++){
            int isPrime = 1;                        //is an int that will act like a bool 
            if(i == 1){                             // 1 is not a prime number so it will not count
                isPrime = 0;
            }
            if(i > 2){
                for(int j = 2; j < i; j++){         // the loop has to start at 2 becase a prime number
                    if((i % j == 0)){               // is only divisable by itself and 1
                        isPrime = 0;                // i % j is used to check if there is a remainder
                    }                               // if there  is none then its not prime
                }
            }
            if(isPrime == 1){                       //"bool" isPrime is checked and if its a prime number then it is printed out
                printf("%d\n", i);
            }
        }
    }

    return 0;
}
