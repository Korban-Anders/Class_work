/**
 * fifteen.c
 *
 * Refer to Computer Science 50
 * Problem Set 3
 *
 * Implements Game of Fifteen (generalized to d x d).
 *
 * Usage: fifteen d
 *
 * whereby the board's dimensions are to be d x d,
 * where d must be in [DIM_MIN,DIM_MAX]
 *
 * Note that usleep is obsolete, but it offers more granularity than
 * sleep and is simpler to use than nanosleep; `man usleep` for more.
 */

#define _XOPEN_SOURCE 500

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

// constants
#define DIM_MIN 3
#define DIM_MAX 9

#ifndef INT_MAX
#define INT_MAX 12345678
#endif // INT_MAX

// board
int board[DIM_MAX][DIM_MAX];

// dimensions
int d;

// prototypes
void greet(void);
void init(void);
void draw(void);
short move(int tile);
short won(void);
int get_int();

int main(int argc, char *argv[])
{
    // ensure proper usage
    if (argc != 2)
    {
        printf("Usage: fifteen d\n");
        return 1;
    }

    // ensure valid dimensions
    d = atoi(argv[1]);
    if (d < DIM_MIN || d > DIM_MAX)
    {
        printf("Board must be between %i x %i and %i x %i, inclusive.\n",
               DIM_MIN, DIM_MIN, DIM_MAX, DIM_MAX);
        return 2;
    }

    // open log
    FILE *file = fopen("log.txt", "w");
    if (file == NULL)
    {
        return 3;
    }

    // greet user with instructions
    greet();

    // initialize the board
    init();

    // accept moves until game is won
    while (1)
    {
        // draw the current state of the board
        draw();

        // log the current state of the board (for testing)
        for (int i = 0; i < d; i++)
        {
            for (int j = 0; j < d; j++)
            {
                fprintf(file, "%i", board[i][j]);
                if (j < d - 1)
                {
                    fprintf(file, "|");
                }
            }
            fprintf(file, "\n");
        }
        fflush(file);
       
        // check for win
        if (won())
        {
            printf("ftw!\n");
            break;
        }

        // prompt for move
        printf("Tile to move: ");
        int tile = get_int();
        printf("\n");

        // quit if user inputs 0 (for testing)
        if (tile == 0)
        {
            break;
        }

        // log move (for testing)
        fprintf(file, "%i\n", tile);
        fflush(file);

        // move if possible, else report illegality
        if (!move(tile))
        {
            printf("\nIllegal move.\n");
            usleep(500000);
        }
        

        // sleep thread for animation's sake
        usleep(500000);
    }

    // close log
    fclose(file);

    // success
    return 0;
}

/**
 * Get an non-negative integer from user input
 * If the input is not non-negative integer, return INT_MAX
 */
int get_int()
{
    int input = 0;
    short invalid = 0;

    char c = getchar();
    if (c == '\n')
        return INT_MAX;

    while (c != '\n')
    {
        if ((c >= '0') && (c <= '9'))
        {
            input = input * 10 + (c - '0');
        }
        else
        {
            invalid = 1;
        }

        c = getchar();
    }

    if (invalid)
        return INT_MAX;
    else
        return input;
}

/**
 * Greets player.
 */
void greet(void)
{
    printf("WELCOME TO GAME OF FIFTEEN\n");
    usleep(2000000);
}

/**
 * Initializes the game's board with tiles numbered 1 through d*d - 1
 * (i.e., fills 2D array with values but does not actually print them).
 */
void init(void)
{
    int dSquared = d * d; // sets up the total number of tiles
    int tileNumber = 0;   // will be used to set the number on each tile

    for (int i = 0; i < d; i++){
        for (int j = 0; j < d; j++){
            ++tileNumber; // indexes the tile number so the board will read D*D - 1 for each tile
            board[i][j] = (dSquared - tileNumber);
        }
    }

    if(d % 2 == 0){
        int tempTile = board[d - 1][d - 2]; // swaps 1 and 2 and the bottom of the board if even
        board[d - 1][d - 2] = board[d - 1][d - 3];
        board[d - 1][d - 3] = tempTile;
    }
}

/**
 * Prints the board in its current state.
 */
void draw(void)
{
    // prints out the game bored and prints a new life after each row to make the right shape
    for (int i = 0; i < d; i++){
        for (int j = 0; j < d; j++){
            board[i][j] != 0 ? printf("%d ", board[i][j]) : printf("_ "); // to the TA or Chen, Ive used this before in C++ i just want to try and use it mpre often
        }
        printf("\n");
    }
}

/**
 * If tile borders empty space, moves tile and returns 1, else
 * returns 0.
 */
short move(int tile)
{

    short vaildMove = 0;
    int tempTile = 0;
    int x = 0,y = 0;
    for(int i = 0; i < d; i++){
        for(int j = 0; j < d; j++){
            if(board[i][j] == 0){
                x = i, y = j;                       //indexs to  find tile location
                if(board[--x][y] == tile){          //checks if the tile is above 0             
                    vaildMove = 1;
                    tempTile = board[i][j];
                    board[i][j] = board[x][y];
                    board[x][y] = tempTile;
                    break;
                }
                x++;                                //resets x
                if(board[++x][y] == tile){          //checks if tile is below 0
                    vaildMove = 1;
                    tempTile = board[i][j];
                    board[i][j] = board[x][y];
                    board[x][y] = tempTile;
                    break;
                }
                x--;                                //resets x, i wish i used a pointer now
                if(board[x][--y] == tile){          //checks if the tile is to the left of 0                
                    vaildMove = 1;
                    tempTile = board[i][j];
                    board[i][j] = board[x][y];
                    board[x][y] = tempTile;
                    break;
                }
                y++;                                // resets y, but i put to much time in to this now
                if(board[x][++y] == tile){          // checks if the tile is to the right of 0
                    vaildMove = 1;
                    tempTile = board[i][j];
                    board[i][j] = board[x][y];
                    board[x][y] = tempTile;
                    break;
                }
                y--;                                //resets y
            }
        }
        if(vaildMove){  // breaks out of loop if valid condition is meet so the program can work right
            break;
        }
    }

    if(vaildMove){
        return 1;
    }else{
        return 0;
    }
}

/**
 * Returns 1 if game is won (i.e., board is in winning configuration),
 * else 0.
 */
short won(void)
{

    short wonCondition = 1;                     //short to use as bool on if the game board is correct
    int tileCheck = 1;                          //checks the tiles to see if they are right

    for(int i = 0; i < d; i++){
        for(int j = 0; j < d; j++){
            if((j == (d-1) && i == (d-1)) && board[d-1][d-1] == 0){     // checks if 0 is at the end of the board
                tileCheck = 0;
            }
            if(board[i][j] != tileCheck){   //if there is a a tile out of order it breaks and makes the wonCondition 0
                wonCondition = 0;
                break;
            }
            ++tileCheck;
        }
    }

    if(wonCondition == 1){
        return 1;
    }else{
        return 0;
    }
}
