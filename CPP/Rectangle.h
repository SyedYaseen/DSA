#pragma once
class Rectangle
{
	double _length;
	double _breadth;
public:
	Rectangle(double l = 0.0, double b = 0.0) {
		_length = l;
		_breadth = b;
	}

	double getArea() {
		return _length * _breadth;
	}

	bool Compare(Rectangle& r2) {
		return this->getArea() < r2.getArea();
	}
};

