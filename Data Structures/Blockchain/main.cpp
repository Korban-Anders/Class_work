/* Program name: M14 Programming Assignment
*  Author: Korban Anders
*  Date last updated: 5/4/2022
* Purpose: create a block chain
*/


#include<iostream>
#include "chain.h"
#include "block.h"
#include "queue.h"


int main(){
    blockChain bc;  
    bc.addBlock("hello IT");
    bc.addBlock("Have You");
    bc.addBlock("Tried Turning it off");
    bc.addBlock("And On Again");

    bc.valadateChain();
    bc.printDigest();
    cout << endl;

    bc.selectBlockToHack();

    bc.printDigest();


    return 0;
}
