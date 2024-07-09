#include <iostream>
#include "User.cpp"
#include "Phone.h"
#include "Rectangle.h"
using namespace std;
int oop() {
	//User yaseen;
	//yaseen.name = "Yaseen";
	//yaseen.printName();
	
	//Inheritance
	//Phone p1;
	//Phone onePlus("OP7", "oxy");
	//
	//onePlus.MakeCall();

	//Phone iPhone = onePlus;

	//std::cout << iPhone.getName() << endl;


	/*
	* Polymorphism 
	* Creating as values and calling methods will call
	* respective methods
	*/
	Phone p1;
	SmartPhone smartPh;
	DumbPhone dumbPh;

	//p1.MakeCall();
	//smartPh.MakeCall();
	//dumbPh.MakeCall();

	/*
	* If there are pointers of One class, 
	* and we assign that pointer to another child or sibling class
	* unless the methods that are called have the virtual keyword it wont execute the method of the correct class
	*/
	
	//Phone* p1Ptr;
	//SmartPhone smartPh2;
	//DumbPhone dumbPh2;
	////p1Ptr = &dumbPh2;
	//p1Ptr->MakeCall();


	//Self referce pointer - this keyword
	//Rectangle r1(2, 2);
	//Rectangle r2(3, 3);
	//cout << r2.Compare(r1);

	return 0;
}