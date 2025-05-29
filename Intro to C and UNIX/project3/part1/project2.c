#include "project2.h"

struct TrieNode *createNode()
{
    struct TrieNode *node = (struct TrieNode *)malloc(sizeof(struct TrieNode));

    if(node != NULL){
        node->isEndOfNode = 0;
        node->numOfOccurrences = 0;

        for (int i = 0; i < ALPHABET_SIZE; i++)
        {
            node->children[i] = NULL;
        }  
    }
    return node;
}

struct TrieNode *indexPage(const char *url, int *pTotalNumTerms)
{
    // Buffer and pointers
    char buffer[BUFSIZE];
    char *current = buffer;
    char *wordStart = current;
    char *word = NULL;
    int wordLength = 0;
    int sumTotalTerms = 0;
    
    // Root of the trie
    struct TrieNode *root = createNode();
    if (root == NULL){
        return NULL; // Safety check 
    }

    printf("%s\n",url);     //prints the url

    // Puts words into buffer
    getText(url, buffer, BUFSIZE);
    int len = strlen(buffer);

    for (int i = 0; i <= len; i++)
    {
        buffer[i] = tolower(buffer[i]); 
        // if we've reached the end of a word or the text
        if (!isalpha(buffer[i]) || i == len)
        {
            if (wordStart) 
            {
                wordLength = (current - wordStart);
                word = malloc(sizeof(char) * wordLength + 1);
                if (!word) return NULL; // Saftey check

                strncpy(word, wordStart, wordLength);
                word[wordLength] = '\0'; 

                printf("\t%s\n", word);         //prints each word in the webstie
                
                // Add the word to the trie
                addWordOccurrence(word, wordLength, root);
                sumTotalTerms++;
                free(word); // Release the word's memory? idk if this should be here but it made sense
                wordStart = NULL; // Reset for the next word
            }
        }
        else if (!wordStart) // if wordStart is null
        {
            // Start of a new word
            wordStart = current;
        }
        current++; // Next character
    }
    *pTotalNumTerms = sumTotalTerms;
    return root; // Return the filled trie
}

int addWordOccurrence(const char *word, const int wordLength, struct TrieNode *root)
{
    int index;

    struct TrieNode *pCrawl = root;

    for(int i = 0; i < wordLength; i++){
        index = (int)word[i] - (int)'a';    //sets index equal to the [i] letter and subratcs it by 'a'
                                            // ie (int)'h' - (int)'a' = 104 - 97 = 7
        if(pCrawl->children[index] == NULL){
            pCrawl->children[index] = createNode();                       //if the trie is at the end and hasnt see the letter is ends the func
        }
        pCrawl = pCrawl->children[index];
    }
    pCrawl->numOfOccurrences++;
    pCrawl->isEndOfNode = 1;
    return 0;
}

void printTrieContents(struct TrieNode *root, char str[], int trieLevel)
{
    if(root->isEndOfNode){
        str[trieLevel] = '\0';
        //printf("%s: %d\n", str, root->numOfOccurrences);   //checks if its at the end of a node then coverts the char[] to a srting and prints it
        printf("\t%s\n", str); 
    }

    for(int i = 0; i < ALPHABET_SIZE; i++){
        if(root->children[i] != NULL){
            str[trieLevel] = i + 'a';
            printTrieContents(root->children[i], str, trieLevel + 1);
        }
    }   // will iterate through a node then and prints all the words with that letter for each letter

}

int freeTrieMemory(struct TrieNode *root)
{
    if (root == NULL)
        free(root);

    for (int i = 0; i < ALPHABET_SIZE; i++)
    {
        if (root->children[i] != NULL)
        {
            freeTrieMemory(root->children[i]);
        }
    }
    free(root);
    return 0;
}

/* You should not need to modify this function */
int getText(const char *srcAddr, char *buffer, const int bufSize)
{

    FILE *pipe;
    int bytesRead;

    snprintf(buffer, bufSize, "curl -s \"%s\" | python3 getText.py", srcAddr);

    pipe = popen(buffer, "r");
    if (pipe == NULL)
    {
        fprintf(stderr, "ERROR: could not open the pipe for command %s\n",
                buffer);
        return 0;
    }

    bytesRead = fread(buffer, sizeof(char), bufSize - 1, pipe);
    buffer[bytesRead] = '\0';

    pclose(pipe);

    return bytesRead;
}
