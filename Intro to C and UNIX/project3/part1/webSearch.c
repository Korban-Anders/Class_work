#include "lib.h"
#include "project1.h"
#include "project2.h"




int main(int argc, char** argv){
    // argv[0] = webSearch
    // argv[1] = URL MaxNumHops
    // argv[2] = MaxNumofWeb sites
    // argv[3] = long seed

    // Argument Check
    if(argc != 4){
        fprintf(stderr, "ERROR: Invalid Amount of Arguments");
        return -1;
    }

    //Opens file
    FILE *fp;
    fp = fopen(argv[1], "r");
    if(fp == NULL){
        fprintf(stderr, "Could not create file (%s).\n", argv[1]);
        return -2;
    }

    // Var from file
    int maxNumWebsites = atoi(argv[2]);
    long seed = atoi(argv[3]);
    char URLAddressStart[MAX_ADDR_LENGTH];
    char URLAddressDest[MAX_ADDR_LENGTH];
    int hopLimit;
    int totalNumTerms = 0;

    srand(seed);
    
    //Sets up Linked list
    struct listNode *pListStart;
    pListStart = malloc(sizeof(struct listNode));
    if(pListStart == NULL){
        fprintf(stderr, "ERROR could not allocate memory\n");
        return -2;
    }

    #if 1

    int pageNum = 0;
    printf("Indexing...\n");
    while(fscanf(fp, "%s %d", URLAddressStart, &hopLimit) == 2 && pageNum < maxNumWebsites){
        int hopNum = 0;
        URLAddressStart[MAX_ADDR_LENGTH - 1] = '\0';

        //gets first URL in the file
        if(pageNum == 0){
            strncpy(pListStart->addr, URLAddressStart, MAX_ADDR_LENGTH);
            pListStart->next = NULL;
            pListStart->trieNode = indexPage(URLAddressStart, &totalNumTerms);
            pageNum++;
        }

        while(1){
            if(contains(pListStart, URLAddressStart) != 1){
                if(pageNum != 0){
                    struct TrieNode *root = indexPage(URLAddressStart, &totalNumTerms);
                    //Inserts word into TrieNode and then pushes the TrieNode into the linked list
                    insertBack(pListStart, URLAddressStart, root);
                }
                
                pageNum++;
            }
            hopNum++;
            //Gets new website
            if(hopNum <= hopLimit && pageNum < maxNumWebsites){
                int res = getLink(URLAddressStart, URLAddressDest, MAX_ADDR_LENGTH);                
                if(!res){
                    //if on a dead end then break out of loop
                    break;
                }
                strncpy(URLAddressStart, URLAddressDest, MAX_ADDR_LENGTH);
            }else{
                break;
            }
        }
    }
    #endif

    
    destroyList(pListStart);


    fclose(fp);
    
    return 0;
}