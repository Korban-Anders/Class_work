#include "block.h"
#include<math.h>
#include<string>
#include<iostream>



block::block(int blockNumber, string data, unsigned int prevHash){  //stets up block
    this->blockNumber = blockNumber;
    this->data = data;
    this->nonce = time(0);
    this->prevHash = prevHash;
    calculateHash();
}

 unsigned int block::calculateHash(){       //calculates hash
    std::hash<string> str_hash;
    string blockData = to_string(nonce) + data + to_string(prevHash);
    this->hash = str_hash(blockData);
    return this->hash;
}

int block::incrementBlockNum(){     //increment block number
    return this->blockNumber += 1;    
}

void block::valadateBlock(){        // valadates block
    if(this->prevHash == this->hash){
        calculateHash();
    }
}

void block::hackBlock(int b){       // hacks block
    this->blockNumber = b;
    calculateHash();
}

