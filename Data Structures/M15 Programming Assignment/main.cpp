#include <iostream>
#include <fstream>
#include <string>
#include <regex>

using namespace std;

int main(){
    regex r1{"^[A-Z]{1}[a-z]{1,}\\s$"};
    regex r2{"[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}"};
    regex r3{"(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])"};
    regex r4{"(\\w+)(\\.|_)?(\\w*)@(\\w+)(\\.(\\w+))+"};
    regex r5{"(\\w+)(\\.|_)?(\\w*)@[ivytech.edu]"};
    regex r6{"\\d{3}\\-\\d{3}-\\d{4}"};
    regex r7{"\\[219|574|260|765|317|463|812|930]\\-\\d{3}-\\d{4}"};
    regex r8{"\\CSCI|SDEV|CSIA\\d{3}" };
    
    ifstream in ("input.txt");
    while(!in.eof()){
        string str;
        if(!getline(in,str)){
            break;
        }
        smatch m;

        //gets first name
        if(regex_search(str, m, r1)){
            cout << "Name Found on " << str << endl;
        }

        //gets first and last
        if(regex_search(str, m, r2)){
            cout << "First and Last Name Found on " << str <<  endl;
        }

        //get IP Address
        if(regex_search(str, m, r3)){
            cout << "IP Address Found on " << str << endl;
        }

        //Gets email
        if(regex_search(str, m, r4)){
            cout << "Email Found on " <<str << endl;
        }

        // gets ivy tech email
        if(regex_search(str, m, r5)){
            cout << "Ivy Tech Email Found on " << str << endl;
        }

        // gets phone number
        if(regex_search(str, m, r6)){
            cout << "Phone Number Found on " << str<< endl;
        }

        //gets indiana phone number
        if(regex_search(str, m, r7)){
            cout << "Indiana Phone Number Found on " << str << endl;
        }
        
        //gets course
        else if(regex_search(str, m, r8)){
            cout << "Course Found on " << str<< endl;
        }
        
    }
    
}