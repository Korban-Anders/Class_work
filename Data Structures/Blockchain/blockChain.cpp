#include "chain.h"
#include "block.h"
#include <iostream>

using namespace std;


void blockChain::addBlock(string b){    //adds block to block chain
    if(blocks.isEmptyQueue()){
        block gen(1, b, 0);
        gen.valadateBlock();
        blocks.enqueue(gen);
    }else{
        block prev = blocks.back();
        block newBlock(prev.incrementBlockNum(), b, prev.calculateHash());
        blocks.enqueue(newBlock);
    }
}

void blockChain::valadateChain(){       //valdates chain
    linkedQueueType<block> Temp;
    while(!blocks.isEmptyQueue()){
        blocks.front().valadateBlock();
        Temp.enqueue(blocks.front());
        blocks.dequeue();
    }
    blocks = Temp;
}
void blockChain::printDigest(){     //prints the chian
    linkedQueueType<block> Temp;
    while(!blocks.isEmptyQueue()){
        cout << blocks.front();
        Temp.enqueue(blocks.front());
        blocks.dequeue();
    }
    while(!Temp.isEmptyQueue()){
        blocks.enqueue(Temp.front());
        Temp.dequeue();
    }
}

void blockChain::selectBlockToHack(){       //finds the block to hack
    linkedQueueType<block> Temp;
    string choice; 
    int newWord;
    while(!blocks.isEmptyQueue()){
        cout << "Would you like to change '" << blocks.front() << "' Enter(Y/N): ";
        cin >> choice;

        if(choice == "Y" || choice == "y"){
            cout <<endl;
            cout << "What would you like to change it too? ";
            cin >> newWord;
            blocks.front().hackBlock(newWord);
        }
        Temp.enqueue(blocks.front());
        blocks.dequeue();
    }
    while(!Temp.isEmptyQueue()){
        blocks.enqueue(Temp.front());
        Temp.dequeue();
    }
}

ostream& operator <<(ostream& out, const block& b){
    out << b.data << " ";
    return out;
}

