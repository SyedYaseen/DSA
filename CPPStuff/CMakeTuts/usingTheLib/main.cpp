#include "../makingLibrary/adder.h"
#include <iostream>

int main() {
    int x = testmathfunc::add(2, 2);

    std::cout << x;

    return 0;
}