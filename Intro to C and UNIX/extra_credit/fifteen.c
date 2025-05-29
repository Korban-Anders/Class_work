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


// prototypes
void greet(void);
void init(int *d, int **board);
void draw(int *d, int **board);
short move(int tile, int *d, int **board);
short won(int *d, int **board);
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
    int d = atoi(argv[1]);
    if (d < DIM_MIN || d > DIM_MAX)
    {
        printf("Board must be between %i x %i and %i x %i, inclusive.\n",
               DIM_MIN, DIM_MIN, DIM_MAX, DIM_MAX);
        return 2;
    }

    int **board;
    board = malloc(sizeof(int*) * d);
    for(int i = 0; i < d; i++){
        board[i] = malloc(sizeof(int) * d);
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
    init(&d, board);

    // accept moves until game is won
    while (1)
    {
        // draw the current state of the board
        draw(&d, board);

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
        if (won(&d, board))
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
        if (!move(tile, &d, board))
        {
            printf("\nIllegal move.\n");
            usleep(500000);
        }
        

        // sleep thread for animation's sake
        usleep(500000);
    }

    // close log
    fclose(file);



    for(int i = 0; i < d; i++){
        int* tempPtr = board[i];
        free(tempPtr);
    }
    free(board);

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
void init(int *d, int **board)
{
    int dSquared = *(d) * *(d); // sets up the total number of tiles
    int tileNumber = 0;   // will be used to set the number on each tile

    for (int i = 0; i < *(d); i++){
        for (int j = 0; j < *(d); j++){
            ++tileNumber; // indexes the tile number so the board will read D*D - 1 for each tile
            board[i][j] = (dSquared - tileNumber);
        }
    }

    if(~(*d) & 1){
        int tempTile = board[*d - 1][*d - 2]; // swaps 1 and 2 and the bottom of the board if even
        board[*d - 1][*d - 2] = board[*d - 1][*d - 3];
        board[*d - 1][*d - 3] = tempTile;
    }
}

/**
 * Prints the board in its current state.
 */
void draw(int *d, int **board)
{
    // prints out the game bored and prints a new life after each row to make the right shape
    for (int i = 0; i < *d; i++){
        for (int j = 0; j < *d; j++){
            board[i][j] != 0 ? printf("%d ", board[i][j]) : printf("_ "); 
        }
        printf("\n");
    }
}

/**
 * If tile borders empty space, moves tile and returns 1, else
 * returns 0.
 */
short move(int tile, int *d, int **board)
{

    short vaildMove = 0;
    int tempTile = 0;
    int emptyTileRow, TileRow;
    int emptyTileCol, TileCol;
    int x, y;

    for(int i = 0; i < *d; i++){
        for(int j = 0; j < *d; j++){
            if(board[i][j] == 0){       //finds the location of the empty tile or 0
                emptyTileRow = i;
                emptyTileCol = j;
            }
            if(board[i][j] == tile){    //finds the location of the tile we want to sawp
                TileRow = i;
                TileCol = j;
            }
        }
    }
    x = emptyTileRow;   //temp to hold row location
    y = emptyTileCol;   //temp to hold col location

    if((((x - 1) == TileRow) && (y == TileCol)) || (((x + 1) == TileRow) && (y == TileCol)) || (((y - 1) == TileCol) && (x == TileRow)) || (((y + 1) == TileCol) && (x == TileRow))){
        vaildMove = 1;
        tempTile = board[emptyTileRow][emptyTileCol];               
        board[emptyTileRow][emptyTileCol] = board[TileRow][TileCol];       //Checks if move is valid them sawps the locations if true
        board[TileRow][TileCol] = tempTile;
    }

    return vaildMove;
}

/**
 * Returns 1 if game is won (i.e., board is in winning configuration),
 * else 0.
 */
short won(int *d, int **board)
{

    short wonCondition = 1;                     //short to use as bool on if the game board is correct
    int tileCheck = 1;                          //checks the tiles to see if they are right

    for(int i = 0; i < *d; i++){
        for(int j = 0; j < *d; j++){
            if((j == (*(d)-1) && i == (*(d)-1)) && board[*(d)-1][*(d)-1] == 0){     // checks if 0 is at the end of the board
                tileCheck = 0;
            }
            if(board[i][j] != tileCheck){   //if there is a a tile out of order it breaks and makes the wonCondition 0
                wonCondition = 0;
                break;
            }
            ++tileCheck;
        }
    }

   return wonCondition;
}
