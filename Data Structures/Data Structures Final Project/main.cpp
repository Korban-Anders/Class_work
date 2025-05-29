/* Program name: Final Project 
*  Author: Korban Anders
*  Date last updated: 5/17/2022
* Purpose: Create a Solitare game know as Congress
*/

#include "stackType.h"
#include "card.h"
#include <iostream>
#include <vector>
#include <algorithm>
#include <random>
#include <iomanip>

using namespace std;

void startUp();
int tableSetUp(vector<card>);
int menuOption();
stackType<card>& returnStack(string s, stackType<card>& B1, stackType<card>& B2, stackType<card>& B3, stackType<card>& B4,
stackType<card>& C1, stackType<card>& C2, stackType<card>& C3, stackType<card>& C4, 
stackType<card>& A1, stackType<card>& A2, stackType<card>& A3, stackType<card>& A4,
stackType<card>& D1, stackType<card>& D2, stackType<card>& D3, stackType<card>& D4,
stackType<card>& HAND, stackType<card>& WS);


int main (){

    startUp();
    
    vector<card> decks; // holds both decks of 104 cards
    vector<card> deck1; // holds one deck of 52 cards
    vector<card> deck2; // holds another deck of 52 cards
    int size = 0;

   for(int i = 1; i < 5; i++){      // puts every cards into both smaller decks
       for(int j = 1; j < 14; j++){
           card c = card(j, i);
           deck1.push_back(c);
           deck2.push_back(c);
           size++;
       }
    }
    size *= 2;

    random_device rd;
    default_random_engine rng(rd());
    shuffle(deck1.begin(), deck1.end(), rng);   // randomizes both decks
    shuffle(deck2.begin(), deck2.end(), rng);

    for(int i = 0; i < size ; i++){ // puts both smaller decks into one super deck
        decks.push_back(deck1[i]);
        decks.push_back(deck2[i]);
    }

/*
    for(int i = 0; i < (size) ; i++){ // puts both smaller decks into one super deck
        cout << i << "   " << decks[i] << endl;
    }
*/

    tableSetUp(decks);
    return 0;
}

void startUp(){
    cout << "Welcome to the Solitare Vairant Congress" << endl << endl;
    cout << "In this verson cards will be desginated as so(Ace of Spades = Ace S) " << endl;
    cout << "Where the first (number/word) is the card's face and the second(letter) is the suit." << endl;

    cout << endl;
    
    cout << "Table layout." << endl;
    cout << "The table will be layed out with the columns as A, B, C, D" << endl;
    cout << "The table will be layed out with the rows as 1, 2, 3, 4" << endl;
    cout << "To use the table you need to select the a spot in the table as such (A1)" << endl;
    cout << "The only exception is the waste basket, for that use (WS)" << endl;

}

int tableSetUp(vector<card> decks){
    stackType<card> A1(200), A2(200), A3(200), A4(200);
    stackType<card> B1(200), B2(200), B3(200), B4(200);
    stackType<card> C1(200), C2(200), C3(200), C4(200);
    stackType<card> D1(200), D2(200), D3(200), D4(200);
    stackType<card> WS(200), HAND(200);

    //default card
    card d = card(0,0);
    //intialize B Stacks
    B1.push(d);
    B2.push(d);
    B3.push(d);
    B4.push(d);

    //intialize C Stacks
    C1.push(d);
    C2.push(d);
    C3.push(d);
    C4.push(d);

    //intialize A Stacks
    A1.push(d);
    A2.push(d);
    A3.push(d);
    A4.push(d);

    //intialize D Stacks
    D1.push(d);
    D2.push(d);
    D3.push(d);
    D4.push(d);

    //intialize WS Stack
    WS.push(d);

    //adds the deck to the HAND stack
    for(int i = 0; i < 104; i++){
        HAND.push(decks[i]);
    }

    // puts a card from hand to A stack
    A1.push(HAND.top());
    HAND.pop();
    A2.push(HAND.top());
    HAND.pop();
    A3.push(HAND.top());
    HAND.pop();
    A4.push(HAND.top());
    HAND.pop();

    // puts a card from hand to D stack
    D1.push(HAND.top());
    HAND.pop();
    D2.push(HAND.top());
    HAND.pop();
    D3.push(HAND.top());
    HAND.pop();
    D4.push(HAND.top());
    HAND.pop();
   

    cout << endl;
    while(true){
        //sets up table
        cout <<  "--------------Table--------------" <<endl;
        cout << " |A" << setw(9) << " |B" << setw(6) << " |C" << setw(6) << " |D" << endl;
        cout << "1|" << setw(5) << A1.top() << "|" << setw(5) << B1.top() <<"|" << setw(5) << C1.top() <<"|" << setw(5) << D1.top() << "|" << endl;
        cout << "2|" << setw(5) << A2.top() << "|" << setw(5) << B2.top() <<"|" << setw(5) << C2.top() <<"|" << setw(5) << D2.top() << "|" << endl;
        cout << "3|" << setw(5) << A3.top() << "|" << setw(5) << B3.top() <<"|" << setw(5) << C3.top() <<"|" << setw(5) << D3.top() << "|" << endl;
        cout << "4|" << setw(5) << A4.top() << "|" << setw(5) << B4.top() <<"|" << setw(5) << C4.top() <<"|" << setw(5) << D4.top() << "|" << endl;
        cout << " |Waste Bucket:" << WS.top() << "|" << setw(10) << "Hand: " << HAND.top() <<  endl;
    

        // gets choice from user
        int choice = menuOption();
        if(choice == 1){
            string stackA, stackB;

            cout << "Please Enter The Location Of The Card You Want To Move:  " << endl;
            cin >> stackA;
            while(stackA != "A1" && stackA != "A2" && stackA != "A3" && stackA != "A4" && stackA != "B1" && stackA != "B2" && stackA != "B3" && stackA != "B4" && stackA != "C1" && stackA != "C2" && stackA != "C3" && stackA != "C4" && stackA != "D1" && stackA != "D2" && stackA != "D3" && stackA != "D4"){
                cout << "InValid Choice Please Try Again" <<endl;
                cin.clear();
                cin.ignore();
                cout << "Please Enter The Location Of The Card You Want To Move:  " << endl;
                cin >> stackA;
            }

            cout << "Please Enter The Location To Move The Card To:  " << endl;
            cin >> stackB;
              while(stackB != "A1" && stackB != "A2" && stackB != "A3" && stackB != "A4" && stackB != "B1" && stackB != "B2" && stackB != "B3" && stackB != "B4" && stackB != "C1" && stackB != "C2" && stackB != "C3" && stackB != "C4" && stackB != "D1" && stackB != "D2" && stackB != "D3" && stackB != "D4"){
                cout << "InValid Choice Please Try Again" <<endl;
                cin.clear();
                cin.ignore();
                cout << "Please Enter The Location To Move The Card To:  " << endl;
                cin >> stackB;  
            }
        
            // if the user wants to move a card to the two center columns
            if(stackB == "B1" || stackB == "B2" || stackB == "B3" || stackB == "B4" || stackB == "C1" || stackB == "C2" || stackB == "C3" || stackB == "C4" ){
                if(returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top() > returnStack(stackB, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top()){
                    returnStack(stackB, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).push(returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top());
                    returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).pop();
                }
                else{
                cout << "Invalid Move" << endl;
                } 
            }

            // if the user wants to move a card to the two outter columns
            if(stackB == "A1" || stackB == "A2" || stackB == "A3" || stackB == "A4" || stackB == "D1" || stackB == "D2" || stackB == "D3" || stackB == "D4" || stackB == "WS" ){
                if(returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top() < returnStack(stackB, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top()){
                    returnStack(stackB, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).push(returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).top());
                    returnStack(stackA, B1, B2, B3, B4, C1, C2, C3, C4, A1, A2, A3, A4, D1, D2, D3, D4, HAND, WS).pop();
                }
                else{
                cout << "Invalid Move" << endl;
                } 
            }
        }
        else if (choice == 2){
            WS.push(HAND.top());    // Moves the card on Hand to Waste basket
            HAND.pop(); // pops hand
        }
        else if(choice == 3){
            return 0;   //quits program
        }
    }
}

int menuOption(){
    int choice;
    cout << "Please Enter An Option" << endl;
    cout << "1. Move A Card That Is On The Board" << endl;
    cout << "2. Draw A Card" << endl;
    cout << "3. Quit Game" << endl;
    cin >> choice;

    return choice;
}


// function that returns stackType that matches the string
stackType<card>& returnStack(string s, stackType<card>& B1, stackType<card>& B2, stackType<card>& B3, stackType<card>& B4,
stackType<card>& C1, stackType<card>& C2, stackType<card>& C3, stackType<card>& C4, 
stackType<card>& A1, stackType<card>& A2, stackType<card>& A3, stackType<card>& A4,
stackType<card>& D1, stackType<card>& D2, stackType<card>& D3, stackType<card>& D4,
stackType<card>& HAND, stackType<card>& WS)
{
    if(s == "A1"){
        return A1;
    }else if(s == "A2"){
        return A2;
    }else if(s == "A3"){
        return A3;
    }else if(s == "A4"){
        return A4;
    }else if(s == "B1"){
        return B1;
    }else if(s == "B2"){
        return B2;
    }else if(s == "B3"){
        return B3;
    }else if(s == "B4"){
        return B4;
    }else if(s == "C1"){
        return C1;
    }else if(s == "C2"){
        return C2;
    }else if(s == "C3"){
        return C3;
    }else if(s == "C4"){
        return C4;
    }else if(s == "D1"){
        return D1;
    }else if(s == "D2"){
        return D2;
    }else if(s == "D3"){
        return D3;
    }else if(s == "D4"){
        return D4;
    }else if(s == "HAND"){
        return HAND;
    }else if(s == "WS"){
        return WS;
    }else{
        return WS;
    }
}
