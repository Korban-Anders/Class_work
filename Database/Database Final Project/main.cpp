/* Program name: Final Project
*  Author: Korban Anders
*  Date last updated: 5/17/2022
* Purpose: Let the user insert, update, and delete order form the NewGen database
*/

#include <iostream>
#include <string>
#include <iomanip>
#include <climits>
#include "sqlite3.h"

using namespace std;

void printMainMenu();
void viewOrder(sqlite3 *);
void updateOrder(sqlite3 *);
void createNewOrder(sqlite3 *);
void deleteOrder(sqlite3 *);
int mainMenu();
void rollback(sqlite3 * db);
void commit(sqlite3* db);

int main(){
    int choice;
    sqlite3 *mydb;
    int rc;
    char *err;

    
    rc = sqlite3_open_v2("NewGen.db", &mydb, SQLITE_OPEN_READWRITE, NULL);  // opens database
    if(rc != SQLITE_OK){
        cout << "Error in connection: " << sqlite3_errmsg(mydb) << endl;
        sqlite3_close(mydb);
        return -1;
    }

    cout << "Welcome to NewGen" << endl;    //prints a menu and gets the users choice
    choice = mainMenu();
    while (true)
    {
        switch (choice)
        {
        case 1:
            viewOrder(mydb);
            break;
        case 2:
            createNewOrder(mydb);
            break;
        case 3:
            deleteOrder(mydb);
            break;
        case 4:
            updateOrder(mydb);
            break;
        case -1:
            return 0;        
        default:
            cout << "That is not a vaild choice." << endl;
        }
        cout << "\n\n";
        choice = mainMenu();
    }
    return 0;
}

void printMainMenu(){
    cout << "Please choose an option (enter -1 to quit):  " << endl;
	cout << "1. View an Order" << endl;
	cout << "2. Place a new Order" << endl;
	cout << "3. Delete an Order" << endl;
    cout << "4. Update an Order" << endl;
	cout << "Enter Choice: ";
}

int mainMenu(){
    int choice = 0;

    printMainMenu();
    cin >> choice;
    while((!cin || choice < 1 || choice > 5) && choice != -1){  //checks if the input is correct
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That is not a vaild choice." << endl << endl;
        printMainMenu();
        cin >> choice;
    }
    return choice;
}

void viewOrder(sqlite3* db){
    string cust_name;
    cin.clear();
    cin.ignore();
    string query;
    sqlite3_stmt *result;
    string strLastError;
    char * err;
    int rc;

//////////////////////////////////////////// Select Customer To Print ////////////////////////////////////////////
    query = "SELECT OrderTable.order_num, Customer.cust_number, Customer.cust_name ";
    query += "FROM OrderTable ";
    query += "JOIN Customer ON OrderTable.cust_num = Customer.cust_number ";
    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
        sqlite3_finalize(result);
        cout << "There was an error selecting patrons: " << strLastError << endl;
        rollback(db);
        return; 
    }
    cout << "Please Enter The Customer Order To View: " << endl;
    int columnCount = sqlite3_column_count(result);

    rc = sqlite3_step(result);
    int i = 1;
    while(rc == SQLITE_ROW){
        cout << i << ". Order Number: " << sqlite3_column_text(result, 0);
        cout << " | Customer Number: " << sqlite3_column_text(result, 1);
        cout << " | Customer Name: " << sqlite3_column_text(result, 2) << endl;
        i++;
        rc = sqlite3_step(result);
    }
    int customer;
    cin >> customer;
    while (!cin || customer < 1 || customer > i){
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That Is Not N Vaild Choice! Try Again!" << endl;
        cin >> customer;
    }

    sqlite3_reset(result);

    for(int j = 0; j < customer; j++){
        sqlite3_step(result);
    }
    cust_name = reinterpret_cast<const char*>(sqlite3_column_text(result, 2));
    
    sqlite3_finalize(result);

    i = 1;

////////////////////////////////////////////////////////// Select Line To Be Printed ////////////////////////////////////////////

    query = "SELECT Dinosaur.dinosaur_species_num as [Dinosaur Number], Dinosaur.dinosaur_species_name as [Dinosaur Name], line.line_price as Price, line.line_units as Units " ;
    query += "FROM Line ";
    query += "JOIN OrderTable ON Line.order_num = OrderTable.order_num ";
    query += "JOIN Dinosaur ON Line.dinosaur_species_num = Dinosaur.dinosaur_species_num ";
    query += "JOIN Customer ON OrderTable.cust_num = Customer.cust_number ";
    query += "WHERE Customer.cust_name = '" + cust_name + "';";

    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
		sqlite3_finalize(result);
		cout << "There was an error: " << strLastError << endl;
		rollback(db);
		return;
    }
    else{
        int columnCount = sqlite3_column_count(result);   // prints the data related to the customer the user entered
        int i = 1;
        cout << left;
        for (int i = 0; i < columnCount; i++)
		{
			cout << "|" << setw(25) << sqlite3_column_name(result, i);
		}
		cout << "|" << endl;

		while (sqlite3_step(result) == SQLITE_ROW)
		{
			for (int i = 0; i < columnCount; i++)
			{
				if (sqlite3_column_type(result, i) != SQLITE_NULL)
					cout << "|" << setw(25) << sqlite3_column_text(result, i);
				else
					cout << "|" << setw(25) << " ";
			}
			cout << "|" << endl;
		}
        sqlite3_finalize(result);
    } 
    
}   

void createNewOrder(sqlite3* db){
    cin.clear();
    cin. ignore();
    //var for user data
    string cust_name;
    int line_units, cust_number, dinosaur_species_num, order_num, line_num = 0;
    double line_price;

    // var for database manip
    string query;
    sqlite3_stmt *pRes;
    string m_strLastError;
    char * err;
    int rc;

//////////////////////////////////////////// Begin Transaction ///////////////////////////////////////
    query = "begin transaction;";
    rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
    if(rc != SQLITE_OK){
        cout << "Error starting transaction: " << err << endl;
        sqlite3_free(err);
        return;
    }

///////////////////////////////////////// Get Customer's Name ////////////////////////////////////////
    cout << "Please Enter The Name For The Order (First Name Last Name): ";
    getline(cin, cust_name);

///////////////////////////////////// Select Gets Customer Number ////////////////////////////////////////
    int i = 0;
    query = "SELECT cust_number ";
    query += "From Customer;";
    if(sqlite3_prepare_v2(db, query.c_str(), -1, &pRes, NULL) != SQLITE_OK){
        m_strLastError = sqlite3_errmsg(db);
        sqlite3_finalize(pRes);
        cout << "There was an error: " << m_strLastError << endl;
        rollback(db);
        return;
    }else{
        while (sqlite3_step(pRes) == SQLITE_ROW)
        {
            i++;
        }
    }
    cust_number = ++i;
    order_num = cust_number;
    //sqlite3_reset(pRes);
    sqlite3_finalize(pRes);

////////////////////////////////////////////////////////// Insert Into Customer /////////////////////////////////////////
    query = "INSERT INTO Customer(cust_number, cust_name) VALUES( ";
    query += to_string(cust_number) + ", '";
    query += cust_name + "' );";

    rc = sqlite3_exec(db, query.c_str(),  NULL, NULL, &err);
    if(rc != SQLITE_OK){
        cout << "Error inserting customer: " << err << endl;
        sqlite3_free(err);
        rollback(db);
        return;
    }
    cout << "Customer Record Inserted." << endl;

//////////////////////////////////////////////////////// Insert Into Order ////////////////////////////////////////////////
    //sqlite3_reset(pRes);
    query = "INSERT INTO OrderTable(order_num, cust_num) VALUES( ";
    query += to_string(order_num) + ", ";
    query += to_string(cust_number) + ");";

    rc = sqlite3_exec(db, query.c_str(),  NULL, NULL, &err);
    if(rc != SQLITE_OK){
        cout << "Error inserting order: " << err << endl;
        sqlite3_free(err);
        rollback(db);
        return;
    }
    cout << "Order Record Inserted." << endl;

////////////////////////////////////////////////// Gets Dinosaurs for the Order /////////////////////////////////
    bool Continue = true;
    while(Continue){
        sqlite3_stmt *pRes2;
        string query2 = "SELECT Dinosaur.dinosaur_species_num, Dinosaur.dinosaur_species_name, dinosaur_cost ";
        query2 += "From Dinosaur;";
        if(sqlite3_prepare_v2(db, query2.c_str(), -1, &pRes2, NULL) != SQLITE_OK){
            m_strLastError = sqlite3_errmsg(db);
            sqlite3_finalize(pRes2);
            cout << "There was an error: " << m_strLastError << endl;
            rollback(db);
            return;
        }else{
            cout << "Please choose a Dinosaur: " << endl;
            int columnCount = sqlite3_column_count(pRes2);
            int i = 1, choice;
            cout << left;
            while (sqlite3_step(pRes2) == SQLITE_ROW)
            {
                cout << i << ". Dinosaur Number: " << sqlite3_column_text(pRes2, 0) << " | Dinosaur Name: " << sqlite3_column_text(pRes2, 1) << " | Price: $" << sqlite3_column_text(pRes2, 2) << endl;
                i++;
            }
            do{
                if(!cin){
                cin.clear();
                cin.ignore();
                }
                cin >> choice;
                if(!cin || choice < 1 || choice > i){
                    cout << "That is not a vaild choice! Try Again!" << endl;
                }
            } while(!cin);
            sqlite3_reset(pRes2);
            for(int i = 0; i < choice; i++){
                sqlite3_step(pRes2);
            }
            dinosaur_species_num = sqlite3_column_int(pRes2, 0);
            line_price = sqlite3_column_double(pRes2, 2);

            sqlite3_finalize(pRes2);

            cout << "How Many Would You Like? ";
            cin >> line_units;

//////////////////////////////////////////////////////// Insert Into Line /////////////////////////////////////////////
            //sqlite3_reset(pRes);
            query = "INSERT INTO Line(order_num, line_num, dinosaur_species_num, line_units, line_price) VALUES( ";
            query += to_string(order_num) + ", ";
            query += to_string(++line_num) + ", ";
            query += to_string(dinosaur_species_num) + ", ";
            query += to_string(line_units) + ", ";
            query += to_string(line_price) + "); ";

            rc = sqlite3_exec(db, query.c_str(),  NULL, NULL, &err);
            if(rc != SQLITE_OK){
                cout << "Error inserting line: " << err << endl;
                sqlite3_free(err);
                rollback(db);
                return;
            }
            cout << "Line Record Inserted." << endl;

//////////////////////////////////////////////// Loop Parts //////////////////////////////////////////////////////
            string loopControl;
            cout << "Would You Like To Add Another Dinosaur? (Y/N): ";
            cin >> loopControl;
            if(loopControl == "N" || loopControl == "n"){
                Continue = false;
            }
        }
    }
    commit(db);
}

void deleteOrder(sqlite3* db){
     // Cust var
    int dinosaur_species_num, order_num, cust_number, line_number, line_units; 
    double dinosaur_cost, line_price;
    // Database var
    string query;
    sqlite3_stmt *result;
    string strLastError;

///////////////////////////////////////////////////////////// Begin Transaction //////////////////////////////////////////////
    query = "begin transaction;";
    char * err;
    int rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
    if(rc != SQLITE_OK){
        cout << "Error starting transaction: " << err << endl;
        sqlite3_free(err);
        return;
    }

///////////////////////////////////////////////////////////// Select Customer to be Deleted /////////////////////////////////////
    query = "SELECT OrderTable.order_num, Customer.cust_number, Customer.cust_name ";
    query += "FROM OrderTable ";
    query += "JOIN Customer ON OrderTable.cust_num = Customer.cust_number ";
    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
        sqlite3_finalize(result);
        cout << "There was an error selecting patrons: " << strLastError << endl;
        rollback(db);
        return; 
    }
    cout << "Please Enter The Customer Order To Delete An Order From: " << endl;
    int columnCount = sqlite3_column_count(result);

    rc = sqlite3_step(result);
    int i = 1;
    while(rc == SQLITE_ROW){
        cout << i << ". Order Number: " << sqlite3_column_text(result, 0);
        cout << " | Customer Number: " << sqlite3_column_text(result, 1);
        cout << " | Customer Name: " << sqlite3_column_text(result, 2) << endl;
        i++;
        rc = sqlite3_step(result);
    }
    int customer;
    cin >> customer;
    while (!cin || customer < 1 || customer > i){
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That Is Not N Vaild Choice! Try Again!" << endl;
        cin >> customer;
    }

    sqlite3_reset(result);

    for(int j = 0; j < customer; j++){
        sqlite3_step(result);
    }
    order_num = sqlite3_column_int(result, 0);
    //cust_number = sqlite3_column_int(result, 1);
    sqlite3_finalize(result);

    i = 1;

////////////////////////////////////////////////////////// Select Line To Be Deleted ////////////////////////////////////////////
    query = "SELECT line_num, dinosaur_species_num, line_units, line_price ";
    query += "FROM Line ";
    query += "WHERE order_num = " + to_string(order_num) + ";";

    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
		sqlite3_finalize(result);
		cout << "There was an error: " << strLastError << endl;
		rollback(db);
		return;
    }

    cout << "Please Enter The Line To Be Deleted: " << endl;
    columnCount = sqlite3_column_count(result);
    rc = sqlite3_step(result);
    while(rc == SQLITE_ROW){
        cout << i << ". Line Number: " << sqlite3_column_text(result, 0);
        cout << " | Dinosaur Number: " << sqlite3_column_text(result, 1);
        cout << " | Units: " << sqlite3_column_text(result, 2);
        cout << " | Price: " << sqlite3_column_text(result, 3);
        cout << endl;
        i++;
        rc = sqlite3_step(result);
    }
    int row;
    cin >> row;

    while(!cin || row < 1 || row > i){
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That Is Not A Vaild Choice! Try Agian!" << endl;
        cin >> row;
    }

    sqlite3_reset(result);

    for(int i = 0; i < row; i++){
        sqlite3_step(result);
    }

    line_number = sqlite3_column_int(result, 0);
    sqlite3_finalize(result);

    query = "DELETE FROM Line ";
    query += "WHERE line_num = " + to_string(line_number) + ";"; 
    rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
	if(rc != SQLITE_OK)
	{
		cout << "Error Deleteing Line: " << err << endl;
		sqlite3_free(err);
		rollback(db);
		return;
	}
    
    commit(db);
}

void updateOrder(sqlite3* db){
    // Cust var
    int dinosaur_species_num, order_num, cust_number, line_number, line_units; 
    double dinosaur_cost, line_price;
    // Database var
    string query;
    sqlite3_stmt *result;
    string strLastError;

///////////////////////////////////////////////////////////// Begin Transaction //////////////////////////////////////////////
    query = "begin transaction;";
    char * err;
    int rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
    if(rc != SQLITE_OK){
        cout << "Error starting transaction: " << err << endl;
        sqlite3_free(err);
        return;
    }

///////////////////////////////////////////////////////////// Select Customer to be Updated /////////////////////////////////////
    query = "SELECT OrderTable.order_num, Customer.cust_number, Customer.cust_name ";
    query += "FROM OrderTable ";
    query += "JOIN Customer ON OrderTable.cust_num = Customer.cust_number ";
    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
        sqlite3_finalize(result);
        cout << "There was an error selecting patrons: " << strLastError << endl;
        rollback(db);
        return; 
    }
    cout << "Please Enter The Customer Order To Update: " << endl;
    int columnCount = sqlite3_column_count(result);

    rc = sqlite3_step(result);
    int i = 1;
    while(rc == SQLITE_ROW){
        cout << i << ". Order Number: " << sqlite3_column_text(result, 0);
        cout << " | Customer Number: " << sqlite3_column_text(result, 1);
        cout << " | Customer Name: " << sqlite3_column_text(result, 2) << endl;
        i++;
        rc = sqlite3_step(result);
    }
    int customer;
    cin >> customer;
    while (!cin || customer < 1 || customer > i){
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That Is Not N Vaild Choice! Try Again!" << endl;
        cin >> customer;
    }

    sqlite3_reset(result);

    for(int j = 0; j < customer; j++){
        sqlite3_step(result);
    }
    order_num = sqlite3_column_int(result, 0);
    sqlite3_finalize(result);

    i = 1;

////////////////////////////////////////////////////////// Select Line Update ////////////////////////////////////////////
    query = "SELECT line_num, dinosaur_species_num, line_units, line_price ";
    query += "FROM Line ";
    query += "WHERE order_num = " + to_string(order_num) + ";";

    rc = sqlite3_prepare_v2(db, query.c_str(), -1, &result, NULL);
    if(rc != SQLITE_OK){
        strLastError = sqlite3_errmsg(db);
		sqlite3_finalize(result);
		cout << "There was an error: " << strLastError << endl;
		rollback(db);
		return;
    }

    cout << "Please Enter The Line To Be Updated: " << endl;
    columnCount = sqlite3_column_count(result);
    rc = sqlite3_step(result);
    while(rc == SQLITE_ROW){
        cout << i << ". Line Number: " << sqlite3_column_text(result, 0);
        cout << " | Dinosaur Number: " << sqlite3_column_text(result, 1);
        cout << " | Units: " << sqlite3_column_text(result, 2);
        cout << " | Price: " << sqlite3_column_text(result, 3);
        cout << endl;
        i++;
        rc = sqlite3_step(result);
    }
    int row;
    cin >> row;

    while(!cin || row < 1 || row > i){
        if(!cin){
            cin.clear();
            cin.ignore();
        }
        cout << "That Is Not A Vaild Choice! Try Agian!" << endl;
        cin >> row;
    }

    sqlite3_reset(result);

    for(int i = 0; i < row; i++){
        sqlite3_step(result);
    }

    line_number = sqlite3_column_int(result, 0);
    sqlite3_finalize(result);

//////////////////////////////////////////////////////////// Updates /////////////////////////////////////////
    int toUpdate;
    bool Continue = true;
    while(Continue){
        cout << "What do you want to update?" << endl;
        cout << "1. Dinosaur" << endl;
        cout << "2. Units" << endl;
        cout << "-1. Quit" << endl;
        cin >> toUpdate;

        if(toUpdate == 2){
/////////////////////////////////////////////////// Updates Units //////////////////////////////////////////////////
            cout << "How Many Units Do You Want? ";
            cin >> line_units;

            query = "UPDATE Line set line_units = ";
            query += to_string(line_units);
            query += " WHERE line_num = ";
            query += to_string(line_number) + " ;";

            rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
	        if(rc != SQLITE_OK)
	        {
		        cout << "Error updating Line: " << err << endl;
		        sqlite3_free(err);
		        rollback(db);
		        return;
	        }
            commit(db);
        } else if(toUpdate == 1){
/////////////////////////////////////////////// Updates Dinosaur and Line Price //////////////////////////////////////////
            sqlite3_stmt *pRes2;
            string query2 = "SELECT Dinosaur.dinosaur_species_num, Dinosaur.dinosaur_species_name, dinosaur_cost ";
            query2 += "From Dinosaur;";
            if(sqlite3_prepare_v2(db, query2.c_str(), -1, &pRes2, NULL) != SQLITE_OK){
                string m_strLastError = sqlite3_errmsg(db);
                sqlite3_finalize(pRes2);
                cout << "There was an error: " << m_strLastError << endl;
                rollback(db);
                return;
            }
            cout << "Please choose a Dinosaur: " << endl;
            int columnCount = sqlite3_column_count(pRes2);
            int i = 1, choice;
            cout << left;
            while (sqlite3_step(pRes2) == SQLITE_ROW)
            {
                cout << i << ". Dinosaur Number: " << sqlite3_column_text(pRes2, 0) << " | Dinosaur Name: " << sqlite3_column_text(pRes2, 1) << " | Price: $" << sqlite3_column_text(pRes2, 2) << endl;
                i++;
            }
            do{
                if(!cin){
                cin.clear();
                cin.ignore();
                }
                cin >> choice;
                if(!cin || choice < 1 || choice > i){
                    cout << "That is not a vaild choice! Try Again!" << endl;
                }
            } while(!cin);
            sqlite3_reset(pRes2);
            for(int i = 0; i < choice; i++){
                sqlite3_step(pRes2);
            }
            dinosaur_species_num = sqlite3_column_int(pRes2, 0);
            line_price = sqlite3_column_double(pRes2, 2);
            sqlite3_finalize(pRes2);
            

            query = "UPDATE Line set dinosaur_species_num = ";
            query += to_string(dinosaur_species_num);
            query += ", line_price = ";
            query += to_string(line_price);
            query += " WHERE line_number = ";
            query += to_string(line_number) + " ;";

            rc = sqlite3_exec(db, query.c_str(), NULL, NULL, &err);
	        if(rc != SQLITE_OK)
	        {
		        cout << "Error updating Line: " << err << endl;
		        sqlite3_free(err);
		        rollback(db);
		        return;
	        }
            commit(db);
        }else if(toUpdate == -1){
            Continue = false;
        }else{
            cout << "Not A Vaild Choice! Try Again" << endl;
        }
        
    }  
    //commit(db);     
}

void rollback(sqlite3* db){
    string query = "rollback;";
    sqlite3_exec(db, query.c_str(), NULL, NULL, NULL);
}

void commit(sqlite3* db){
    string query = "commit;";
    sqlite3_exec(db, query.c_str(), NULL, NULL, NULL);
}