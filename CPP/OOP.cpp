#include <iostream>
#include "User.cpp"
#include "Phone.h"
#include "Rectangle.h"
using namespace std;
int main() {
	//User yaseen;
	//yaseen.name = "Yaseen";
	//yaseen.printName();
	
	//Inheritance, Polymorphism
	//Phone p1;
	Phone onePlus("OP7", "oxy");
	
	onePlus.MakeCall();

	Phone iPhone = onePlus;

	std::cout << iPhone.getName() << endl;

	//Rectangle r1(2, 2);
	//Rectangle r2(3, 3);
	//cout << r2.Compare(r1);

	return 0;
}