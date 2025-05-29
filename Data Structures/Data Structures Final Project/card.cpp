#include "card.h"

card::card(int cardNumber, int cardSuit){
    this -> cardSuit = cardSuit;
    this -> cardNumber = cardNumber;
}

bool card::operator==(const card& c){
    return c.cardNumber == this->cardNumber && c.cardSuit == this->cardSuit;
}

bool card::operator!=(const card& c){
    return !(*this == c);
}

bool card::operator<(const card& c){
   return c.cardNumber < this->cardNumber;
}

bool card::operator>(const card& c){
    if((this->cardSuit == 0 && this->cardNumber == 0) || (c.cardNumber == 0 && c.cardSuit == 0)){
        return c.cardNumber < this->cardNumber;
    } else{
        return c.cardNumber < this->cardNumber && c.cardSuit == this->cardSuit;
    }
}   

ostream& operator <<(ostream& out, const card& c){
    out << cardNumToString.at(c.cardNumber) << suitToString.at(c.cardSuit);
    //out << to_string(c.cardNumber) << to_string(c.cardSuit);

    return out;
}