    // First and Last Name
    ifstream in2 ("input.txt");
    regex r1{"^[A-Z]{1}[a-z]{1,}+$"};
    regex r2{"^[A-Z]{1}[a-z]{1,}"};
    regex r3{"(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])"};
    regex r4{"(\\w+)(\\.|_)?(\\w*)@(\\w+)(\\.(\\w+))+"};
    regex r5{"(\\w+)(\\.|_)?(\\w*)@[ivytech.edu]"};
    regex r6{"\\d{3}\\-\\d{3}-\\d{4}"};
    regex r7{"\\[219|574|260|765|317|463|812|930]\\-\\d{3}-\\d{4}"};
    regex r8{"\\CSCI|SDEV|CSIA\\d{3}" };

    while(!in2.eof()){
        string str;
        if(!getline(in2,str)){
            break;
        }
        smatch m;

        if(regex_search(str, m, r1)){
            cout << "Name Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r2)){
            cout << "First and Last Name Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r3)){
            cout << "IP Address Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r4)){
            cout << "Email Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r5)){
            cout << "Ivy Tech Email Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r6)){
            cout << "Phone Number Found on '" << m[1].str() << "'" << endl;
        }

        if(regex_search(str, m, r7)){
            cout << "Indiana Phone Number Found on '" << m[1].str() << "'" << endl;
        }
        
        if(regex_search(str, m, r)){
            cout << "Course Found on '" << m[1].str() << "'" << endl;
        }

        in2.close();
    }