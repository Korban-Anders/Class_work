#ifndef CARD_H
#define CARD_H
#include <map>
#include <string>

using namespace std;

const map<int, string> suitToString = {{0,""},{1," H "},{2, " S "},{3, " D "},{4, " C "}};

const map<int, string> cardNumToString = {{0,""},{1, "Ace"},{2, "2"},{3, "3"},{4, "4"},{5,"5"},{6,"6"},
{7,"7"},{8,"8"},{9,"9"},{10,"10"},{11,"Jack"},{12,"Queen"},{13,"King"}};


class card{
    public: 
    card(int, int);
    bool operator ==(const card&);
    bool operator !=(const card&);
    bool operator > (const card&);
    bool operator < (const card&);
    friend ostream& operator<<(ostream&, const card&);
    
    private:
    int cardNumber;
    int cardSuit;
};






























#endif