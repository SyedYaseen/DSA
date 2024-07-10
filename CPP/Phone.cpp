#include "Phone.h"


// Param constructor
Phone::Phone(const std::string& name, const std::string& os) : _name(name), _os(os) {
    std::cout << "This is param constructor override\n";
}

// Copy constructor
Phone::Phone(const Phone& phone) {
    std::cout << "copy constructor override\n";
    _name = "extra" + phone._name;
    _os = phone._os;
}

// MakeCall function
void Phone::MakeCall() {
    std::cout << "Base class\n";
}