#include <iostream>
#include "User.cpp"
#include "Phone.h"
#include "functors.h"
#include "Rectangle.h"
#include <vector>

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
	//Phone p1;
	//SmartPhone smartPh;
	//DumbPhone dumbPh;

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


	// swap with pointers - move semantics
	//int a = 5;
	//int b = 10;
	//int temp = move(a);

	//a = move(b);
	//b = move(temp);



	//std::cout << "Swap" << a << b;

	// Vectors
	//vector<int> items = {1,2,3,4};
	//
	//for (auto i = items.begin(); i != items.end(); i++) {
	//
	//	printf("%d\n", *i);
	//}

	//for (int i = 0; i < items.size(); i++) {
	//	cout << items[i];
	//}

	// lambda func
	//[] {std::cout << "This ios a lamb\n"; }();
	//auto add = [](const int &a, const int &b) {return a+b; }; // when there is a return type move () after the []
	//std::cout << add(3,5);

	// Functors and operator override

	Functors f(1.5);
	f(2.5);
	f.getVal();


	return 0;
}