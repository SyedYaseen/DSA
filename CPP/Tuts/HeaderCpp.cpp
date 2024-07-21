#include "Header1.h"
#include <iostream>

Foo::Foo(const int val) : _bar(val) {}

void Foo::showbar() {
	std::cout << this->_bar;
}