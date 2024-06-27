// CPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;

int main()
{

    // In out
    //string firstName;
    //string lastName;

    //cout << "Enter your first name: ";
    //getline(cin, firstName);

    //cout << "Enter your last name:";
    //getline(cin, lastName);
    //cout << firstName + " " << lastName << endl;

    // Pointers
    // & before a variable shows the memory address - this is a pointer and can be assigned to data type of pointer
    // * before a memory address (i.e.) a pointer deferences it and gives the value on that address. 
    // 
    int age = 30;
    int* agePointer = &age; // A pointer to the memory location of age variable
    int ageDeref = *agePointer; // Putting star before pointer dereference the pointer and shows the value in memory pointed by the pointer
    
    int& ageRef = age;
    int* pAgeRef = &ageRef;
    ageRef = 27;


    //cout << "age " << age << endl; 
    //cout << "age* " << &age << endl;
    //cout << "age* " << *&age << endl;
    //cout << "agePointer " << agePointer << endl;
    //cout << "ageDeref " << ageDeref << endl;
    //cout << "ageDeref& " << &ageDeref << endl;
    //cout << "ageRef " << ageRef << endl;
    //cout << "pAgeRef " << pAgeRef << endl;

    int a = 5;
    int& aAmber = a;
    int* aPtr = &a;

    cout << "int& a: " << aAmber << endl;
    cout << "aPtr: " << aPtr << endl;
    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
