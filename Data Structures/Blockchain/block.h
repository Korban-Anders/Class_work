#ifndef block_h
#define block_h

#include <string>
#include <functional>
#include <ctime>

using namespace std;

class block{
    public: 
        block(int blockNumber, string data, unsigned int prevHash);
        unsigned int calculateHash();
        int incrementBlockNum();
        void valadateBlock();
        void hackBlock(int b);
        friend ostream& operator<<(ostream&, const block&);
    private:
        int blockNumber;
        string data;
        int nonce;
        unsigned int prevHash;
        unsigned int hash;

};









#endif