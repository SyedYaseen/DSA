#include "../makingLibrary/adder.h"
#include <iostream>

int main() {
    int x = testmathfunc::add(5, 7);

    std::cout << x;

    return 0;
}