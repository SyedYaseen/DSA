
#include <iostream>
#include <string>
using namespace std;

class User {
	int secret = 22;
public:
	string name = "default";
	void printName() {
		cout << "Hi, " << name << endl;
	}
	void setSecret(const int &sec) {
		// Adding const to the method argument works because it allows the 
		// method to accept both lvalues and rvalues.When you add const to a 
		// reference, it means the method promises not to modify the referenced
		// value.This makes it safe to bind the reference to a temporary rvalue 
		// because the temporary value won't be modified.
		secret = sec;
	}
	int getSecret() { return secret; }
};