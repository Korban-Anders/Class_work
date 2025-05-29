#pragma once
#ifndef PROJECT_2_H_
#define PROJECT_2_H_

#include "lib.h"


struct TrieNode
{
    struct TrieNode *children[ALPHABET_SIZE];
    int numOfOccurrences;
    short isEndOfNode;
};


struct TrieNode *createNode();

struct TrieNode *indexPage(const char *url, int *pTotalNumTerms);

int addWordOccurrence(const char *word, const int wordLength, struct TrieNode *trieNode);

void printTrieContents(struct TrieNode *tireNode, char str[], int trieLevel);

int freeTrieMemory(struct TrieNode *trieNode);

int getText(const char *srcAddr, char *buffer, const int bufSize);



















#endif