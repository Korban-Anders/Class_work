#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#define MAX_ADDR_LENGTH 1000

/*
 * a node in our linked-list of web addresses
 */
struct listNode{
  char addr[MAX_ADDR_LENGTH];

  struct listNode *next;
};

/*
 * returns 1 if the list starting at pNode contains the address addr,
 *    and returns 0 otherwise
 */
int contains(const struct listNode *pNode, const char *addr);

/*
 * inserts the address addr as a new listNode at the end of
 *    the list
 */
void insertBack(struct listNode *pNode, const char *addr);

/*
 * prints the addresses from pNode to the end of the list,
 *   one on each line
 */
void printAddresses(const struct listNode *pNode);

/*
 * frees the memory associated with this node and all subsequent nodes
 */
void destroyList(struct listNode *pNode);
  
/*
 * srcAddr should be a web address (e.g., http://www.yahoo.com).
 * link should point to an array of maxLinkLength characters.
 * getLink returns 1 if a link was found and 0 otherwise.
 * If a link was found, "link" will be filled in with the web address.
 */
int getLink(const char* srcAddr, char* link, const int maxLinkLength);

int main(int argc, char** argv){
  #if 1
  long seed;

  char startAddr[MAX_ADDR_LENGTH];
  char destAddr[MAX_ADDR_LENGTH];
  
  int hopNum, numHops;
  #endif

  struct listNode *pListStart;

  #if 0
  pListStart = malloc(sizeof(struct listNode));
  *pListStart->addr = 'A';
  pListStart->next = NULL;
  #endif

  

  #if 1
  if(argc < 3 || argc > 4){
    fprintf(stderr, "USAGE: %s startAddr numHops [rand seed]", argv[0]);
    return -1;
  }
  
  /* initialization */
  if(argc >= 4){
    seed = atol(argv[3]);
  }
  else{
    seed = time(NULL);
  }

  printf("seed = %ld\n", seed);
  srand(seed);

  strncpy(startAddr, argv[1], MAX_ADDR_LENGTH);
  startAddr[MAX_ADDR_LENGTH - 1] = '\0';

  numHops = atoi(argv[2]);

  pListStart = malloc(sizeof(struct listNode));
  if(pListStart == NULL){
    fprintf(stderr, "ERROR: could not allocate memory\n");
    return -2;
  }
  strncpy(pListStart->addr, startAddr, MAX_ADDR_LENGTH);
  pListStart->next = NULL;

  /* start the crawling */
  for(hopNum=1; hopNum <= numHops; hopNum++){
    int res = getLink(startAddr, destAddr, MAX_ADDR_LENGTH);

    if(!res){
      printf("Dead end on hop %d: no outgoing links\n", hopNum);
      break;
    }

    if(contains(pListStart, destAddr)){
      printf("Cycle detected on hop %d: address %s\n", hopNum, destAddr);
      hopNum--; // try again for this hop in the next iteration
    }
    else{
      insertBack(pListStart, destAddr);
      strncpy(startAddr, destAddr, MAX_ADDR_LENGTH);
    }
  }

  #endif

  printAddresses(pListStart);


  destroyList(pListStart);

  return 0;
}


/*
 * returns 1 if the list starting at pNode contains the address addr,
 *    and returns 0 otherwise
 */
int contains(const struct listNode *pNode, const char *addr){
  if(pNode == NULL){                        //if pNode is null its at the end of the  linked list and returns 0 for not found
    return 0;
  }else if(strcmp(pNode->addr, addr)==0){   //if pNode is equal to addr then returns 1
    return 1;
  }else{
    return contains(pNode->next, addr);     //recursively looks in the linked list
  }
}
    

/*
 * inserts the address addr as a new listNode at the end of
 *    the list
 */
void insertBack(struct listNode *pNode, const char *addr){
  if(pNode->next == NULL){                          //checks if next node is null
    pNode->next = malloc(sizeof(struct listNode));  //allocates memmory to new node
    strncpy(pNode->next->addr, addr, MAX_ADDR_LENGTH);  //copies addr to new nodes addr
    pNode->next->next = NULL;                           //sets new nodes next to null
  }else{
    insertBack(pNode->next, addr);                  //recursively checks where to add a node
  }
}


/*
 * prints the addresses from pNode to the end of the list,
 *   one on each line
 */
void printAddresses(const struct listNode *pNode){
  if(pNode != NULL){                                    // checks if node is null
    printf("%s\n", pNode->addr);              //prints nodes address
    printAddresses(pNode->next);                        //recursively prints out all nodes
  }
}

/*
 * frees the memory associated with this node and all subsequent nodes
 */
void destroyList(struct listNode *pNode){
  if(pNode != NULL){
    struct listNode *temp;    //temp node to hold base pNode
    temp = pNode;
    pNode = pNode->next;    //sets pNode to the next node
    free(temp);             //deletes the memory of base node
    destroyList(pNode);     // recusion to delete all nodes
  }
}
  


int getLink(const char* srcAddr, char* link, const int maxLinkLength){
  const int bufSize = 1000;
  char buffer[bufSize];

  int numLinks = 0;

  FILE *pipe;

  snprintf(buffer, bufSize, "curl -s \"%s\" | python3 getLinks.py", srcAddr);

  pipe = popen(buffer, "r");
  if(pipe == NULL){
    fprintf(stderr, "ERROR: could not open the pipe for command %s\n", buffer);
    return 0;
  }

  fscanf(pipe, "%d\n", &numLinks);

  if(numLinks > 0){
    int linkNum;
    double r = (double)rand() / ((double)RAND_MAX + 1.0);

    for(linkNum=0; linkNum<numLinks; linkNum++){
      fgets(buffer, bufSize, pipe);
      
      if(r < (linkNum + 1.0) / numLinks){
		    break;
      }
    }

    /* copy the address from buffer to link */
    strncpy(link, buffer, maxLinkLength);
    link[maxLinkLength-1] = '\0';
    
    /* get rid of the newline */
    {
      char* pNewline = strchr(link, '\n');
      if(pNewline != NULL){
		    *pNewline = '\0';
      }
    }
  }

  pclose(pipe);

  if(numLinks > 0){
    return 1;
  }
  else{
    return 0;
  }
}
