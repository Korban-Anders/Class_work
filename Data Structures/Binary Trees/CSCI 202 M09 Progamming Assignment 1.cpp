#include <iostream>
#include "customer.h"
#include "binaryTrees.h"
using namespace std;

void insertCustomer(binarySearchTree<customer>);
int compareByID(customer cust1, customer cust2);

int main()
{
	binarySearchTree<customer> tree;
	int menuChoice = 0;

	while (menuChoice != 4) {
		cout << "Menu Options: " << endl;
		cout << "1. Add Cutomer" << endl;
		cout << "2. Display Customers" << endl;
		cout << "3. Search For Customer" << endl;
		cout << "4. Exit" << endl;
		cin >> menuChoice;

		if (menuChoice == 1) {
			insertCustomer(tree);
		}
		else if (menuChoice == 2) {

		}
		else if (menuChoice == 3) {

		}
		else if (menuChoice == 4) {

		}
		else {
			cout << "You Did Not Enter A Vaild Number Please Try again." << endl;
		}
	}

	return 0;
}


void insertCustomer(binarySearchTree<customer> tree)
{
	int id;
	string name, address, phone, temp;
	customer* x;
	cout << "Enter the customer id: ";
	cin >> id;
	while (!cin)
	{
		cin.clear();
		cin.ignore(1000, '\n');
		cout << "The customer id should be a whole number." << endl;
		cout << "Enter the customer id: ";
		cin >> id;
	}
	cout << endl;
	cin.get();
	cout << "Enter the customer name (first and last): ";
	getline(cin, name);
	cout << endl;
	cout << "Enter " << name << "'s street address: ";
	getline(cin, temp);
	address = temp;
	cout << endl;
	cout << "Enter the city, state and zip code for the address: ";
	getline(cin, temp);
	address = address + "\n" + temp;
	cout << endl;
	cout << "Enter " << name << "'s phone number: ";
	getline(cin, phone);
	cout << endl;
	x = new customer(name, id, address, phone);
	tree.insert(*x, compareByID);
	delete x;
}

int compareByID(customer cust1, customer cust2)
{
	if (cust1.getId() > cust2.getId())
		return 1;
	else if (cust1.getId() < cust2.getId())
		return -1;
	else
		return 0;
}