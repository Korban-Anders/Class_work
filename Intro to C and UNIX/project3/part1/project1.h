#pragma once
#ifndef PROJECT_1_H_
#define PROJECT_1_H_


#include "lib.h"
#include "project2.h"

struct listNode{
    char addr[MAX_ADDR_LENGTH];
    int hopNum;
    struct TrieNode *trieNode;
    struct listNode *next;
};

int contains(const struct listNode *pNode, const char *addr);

void insertBack(struct listNode *pNode, const char *addr, struct TrieNode *root);

void printAddresses(const struct listNode *pNode);

void destroyList(struct listNode *pNode);

int getLink(const char* srcAddr, char* link, const int maxLinkLength);















#endif
