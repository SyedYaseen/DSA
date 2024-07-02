#include <iostream>
#include "User.cpp"
using namespace std;
int main() {
	User yaseen;
	yaseen.name = "Yaseen";

	yaseen.printName();
	yaseen.setSecret(12);
	cout << yaseen.getSecret() << endl;
	return 0;
}