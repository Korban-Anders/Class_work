#include "project1.h"

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
void insertBack(struct listNode *pNode, const char *addr, struct TrieNode *root){
  if(pNode->next == NULL){                          //checks if next node is null
    pNode->next = malloc(sizeof(struct listNode));  //allocates memmory to new node
    strncpy(pNode->next->addr, addr, MAX_ADDR_LENGTH);  //copies addr to new nodes addr
    pNode->next->trieNode = root;

    pNode->next->next = NULL;                           //sets new nodes next to null
  }else{
    insertBack(pNode->next, addr, root);                  //recursively checks where to add a node
  }
}

/*
 * prints the addresses from pNode to the end of the list,
 *   one on each line
 */
void printAddresses(const struct listNode *pNode){
  if(pNode != NULL){                                    // checks if node is null
    printf("%s\n", pNode->addr);
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
    freeTrieMemory(temp->trieNode);
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
