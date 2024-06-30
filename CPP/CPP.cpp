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
    
    // int& declares references to a value e.g. int a = 5; int& b = a; b = 10; will change value of a and b to 10 becuase both refer to the same memory location.
    // if we do int a = 5; int b = a; there are two memory allocations created, changing values on either will not affect the other

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
    int* aAmberPtr = &aAmber;

    //cout << "int& a: " << aAmber << endl;
    //cout << "aPtr: " << aPtr << endl;
    //cout << "aAmberPtr: " << aAmberPtr << endl;

    int b = a;
    int& c = a;
    b = 10;
    c = 15;
    //cout << "a: " << a << endl;
    //cout << "b: " << b << endl;
    //cout << "int& a: " << &a << endl;
    //cout << "int& b: " << &b << endl;
    //cout << "int& c: " << &c << endl;

    // Arr and pointers

    int myArr[5];
    myArr[0] = 1;
    myArr[1] = 2;

    int* myAp = myArr;
    
    //*myAp = 15;
    //myAp++;
    //myAp++;
    //myAp++;
    //*myAp = 200;
    
    
    //cout << "ar: " << myArr[0] << endl;
    //cout << "ar: " << myArr[1] << endl;
    //cout << "ar: " << myArr[2] << endl;
    //cout << "ar: " << myArr[3] << endl;
    //cout << "ar: " << *myAp << endl; // Shows value, because that start before the pionter dereferences the value
    //cout << "ar: " << myAp << endl; // Shows pointer address
    

    // Size check
    //printf("Size of short int is: %ld bytes = %ld bits \n", sizeof(short int), sizeof(short int) * 8);
    //printf("Size of int is: %ld bytes = %ld bits \n", sizeof(int), sizeof(int) * 8);
    //printf("Size of long int is: %ld bytes = %ld bits \n", sizeof(long int), sizeof(long int) * 8);
    //printf("Size of long long int is: %ld bytes = %ld bits \n", sizeof(long long int), sizeof(long long int) * 8);
    //printf("Size of char is: %ld bytes = %ld bits \n", sizeof(char), sizeof(char) * 8);
    //printf("Size of string is: %ld bytes = %ld bits \n", sizeof(string), sizeof(string) * 8);


    // Conditionals and loops
    int i = 0;

    //while (i < 5) {
    //    cout << *myAp << endl;
    //    myAp++; // by incrementing the pointer
    //    i++;
    //}

    //while (i < 5) {
    //    cout << myArr[i] << endl;
    //    i++;
    //}
    
    //for (int i = 0; i < 5; i++)
    //{
    //    cout << myArr[i] << endl;
    //}

    char name[] = "yaseen"; // all strings have a 0 at the end when they compile, thats how they determine that a string is over
    char nameAsArr[] = { 'y', 'a', 's', 'e', 'e', 'n', 0 }; 
    
    //using int
    //for (int i = 0; i < name[i] != 0; i++) // value 0, false, NULL == false, anything other than this is a true value
    //{
    //    cout << name[i] << endl;
    //}

    // using pointer - init pointer to start of arr; check if deref'd pointer is not 0; increment pointer
    for (char *cp = name; *cp != 0; cp++) // value 0, false, NULL == false, anything other than this is a true value
    {
        //cout << *cp << endl;
    }

    int* myP;

    try
    {
        myP = new int[10000];

        delete[] myP; // after op complete remove memory to prevent memory leaks
         
    }
    catch (...)
    {
        printf("Failed malloc");
    }
    

    // structs
    struct Emp {
        const int uid;
        const char* name;
        int course_count;
    };

    Emp yaseen = { 001, "Yaseen", 1 };
    Emp bismi = { 002, "Almas", 1 };
    // Can change the name even though its const, because it points to 
    // the pointer and we can change the value
    // in the address but not the address itself.
    yaseen.name = "Syed";
    Emp* bPtr = &bismi;

    printf(yaseen.name);
    printf("\n");
    printf(bPtr->name); // access pointer with "->"









    return 0;
}

