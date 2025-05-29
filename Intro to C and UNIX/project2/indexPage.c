/* File: indexPage.c */
/* Author: Britton Wolfe */
/* Date: September 3rd, 2010 */

/* This program indexes a web page, printing out the counts of words on that page */

#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define ALPHABET_SIZE 26
#define BUFSIZE 300000
#define WORDSIZE 100

struct TrieNode
{
    struct TrieNode *children[ALPHABET_SIZE];
    int numOfOccurrences; // will increment
    short isEndOfNode;    // 1 or 0
};

struct TrieNode *indexPage(const char *url);

int addWordOccurrence(const char *word, const int wordLength, struct TrieNode *root);

void printTrieContents(struct TrieNode *root, char str[], int trieLevel);

int freeTrieMemory(struct TrieNode *root);

int getText(const char *srcAddr, char *buffer, const int bufSize);

int main(int argc, char **argv)
{
    // values that are needed to have a recursive function
    int trieLevel = 0;
    char bufferStr[WORDSIZE];
    if (argc != 2)
    {
        printf("Insufficient arguements");
        return -1;
    }

    struct TrieNode *root = indexPage(argv[1]);

    printTrieContents(root, bufferStr, trieLevel);
    freeTrieMemory(root);

    return 0;
}

struct TrieNode *createNode()
{
    struct TrieNode *node = (struct TrieNode *)malloc(sizeof(struct TrieNode));
    if (node == NULL)
        return NULL; // Saftey check

    node->isEndOfNode = 0;
    node->numOfOccurrences = 0;
    for (int i = 0; i < ALPHABET_SIZE; i++)
    {
        node->children[i] = NULL;
    }
    return node;
}

struct TrieNode *indexPage(const char *url)
{
    // Buffer and pointers
    char buffer[BUFSIZE];
    char *current = buffer;
    char *wordStart = current;
    char *word = NULL;
    int wordLength = 0;

    // Root of the trie
    struct TrieNode *root = createNode();
    if (root == NULL)
        return NULL; // Safety check

    printf("%s\n", url);
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
                if (word == NULL)
                    return NULL; // Saftey check

                strncpy(word, wordStart, wordLength);
                word[wordLength] = '\0';

                printf("\t%s\n", word);
                addWordOccurrence(word, wordLength, root); // Add the word to the trie

                free(word);       // Release the word's memory
                wordStart = NULL; // Reset for the next word
            }
        }
        else if (wordStart == NULL)
        {
            wordStart = current; // Start of a new word
        }
        current++; // Next character
    }

    return root; // Return the filled trie
}

int addWordOccurrence(const char *word, const int wordLength, struct TrieNode *root)
{
    int index;

    struct TrieNode *pCrawl = root;

    for (int i = 0; i < wordLength; i++)
    {
        index = (int)word[i] - (int)'a'; // sets index equal to the [i] letter and subratcs it by 'a'
                                         //  ie (int)'h' - (int)'a' = 104 - 97 = 7
        if (pCrawl->children[index] == NULL)
        {
            pCrawl->children[index] = createNode();
        }
        pCrawl = pCrawl->children[index];
    }
    pCrawl->numOfOccurrences++;
    pCrawl->isEndOfNode = 1;
    return 0;
}

void printTrieContents(struct TrieNode *root, char str[], int trieLevel)
{
    if (root->isEndOfNode)
    {
        str[trieLevel] = '\0';
        printf("%s: %d\n", str, root->numOfOccurrences);
    } // checks if its at the end of a node then coverts the char[] to a srting and prints it

    for (int i = 0; i < ALPHABET_SIZE; i++)
    {
        if (root->children[i] != NULL)
        {
            str[trieLevel] = i + 'a';
            printTrieContents(root->children[i], str, trieLevel + 1);
        }
    } // will iterate through a node then and prints all the words with that letter for each letter
}

int freeTrieMemory(struct TrieNode *root)
{
    if (root == NULL)
        return 0;

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
        fprintf(stderr, "ERROR: could not open the pipe for command %s\n", buffer);
        return 0;
    }

    bytesRead = fread(buffer, sizeof(char), bufSize - 1, pipe);
    buffer[bytesRead] = '\0';

    pclose(pipe);

    return bytesRead;
}
