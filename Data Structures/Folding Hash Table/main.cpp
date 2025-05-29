/* Program name: M11 Lecture Lab
*  Author: Korban Anders
*  Date last updated: 4/13/2022
* Purpose: Write a Folding hash
*/



#include<iostream>
#include<fstream>
#include <cmath>
#include "hashtable.h"
using namespace std;

int digitCount(int num);
int hashFolding(int key);

int main(){
    
    int ht[10];

    ifstream in;
    in.open("input.txt");   //imports data from an input.txt

    for(int i = 0; i < 10; i++){    // fills hash array with -1
        ht[i] = -1;    
    }

    int count = 0; 
    while(count < 10){
        int input;
        in >> input;        //gets input from input.txt
      
        if(ht[hashFolding(input)] == -1)
        {                                   // if hash array value is -1 put value there
            ht[hashFolding(input)] = input;
        }
        else if(ht[hashFolding(input)] != input)    //else rehash it
        {
            cout << input << " collided with " << ht[hashFolding(input)] << endl;

        }
        cout << "HT["<< hashFolding(input) << "] <- " << input << endl;
        count++;
    }
    

    return 0; 
}

int hashFolding(int key){   //hash function 
    int tenFold = 10;
    int hash;

    tenFold = pow(10, (digitCount(key) / 2));   // math that spilts key 
    int part1 = key % tenFold;
    int part2 = key / tenFold;
    
    if(digitCount(part1) > (digitCount(key) / 2)  || digitCount(part2) > (digitCount(key) / 2)){
        hashFolding(part1);         //recusrion to keep spliting key if possible
        hashFolding(part2);
    }
    else {
        hash = (part1 + part2);     //hash creation
    }
    return hash % 10;
}

int digitCount(int num){    // gets length of digits
    int count = 1;
    while(num > 9){
        num /= 10;
        count ++;
    }
    return count;
}