#ifndef chain_h
#define chain_h

#include "block.h"
#include "queue.h"

class blockChain{
    public: 
        void addBlock(string data);
        void valadateChain();
        void printDigest();
        void selectBlockToHack();
    private:
        linkedQueueType<block> blocks;

};











#endif