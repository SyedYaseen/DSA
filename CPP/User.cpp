
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
};