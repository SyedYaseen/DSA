#pragma once
#include <iostream>
class Functors
{
	float _ft;

public:

	Functors(float v) {
		std::cout << "This is called\n";
		_ft = v;
	}

	void getVal() {
		std::cout << _ft << std::endl;
	}

	void operator () (float val) {
		_ft += val;
	}
};

