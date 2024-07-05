#pragma once
#ifndef PHONE_H
#define PHONE_H

#include <iostream>
#include <string>

class Phone {
    std::string _name;
    std::string _os;
    //Phone(); //Adding default construvtor here will make this unacessible

public:
    Phone() {
        std::cout << "This default\n";
    }; // Default constructor
    Phone(const std::string& name, const std::string& os); // Param constructor
    Phone(const Phone& phone);
    virtual void MakeCall();
    std::string getName() { return _name; }
    ~Phone() {
        std::cout << "Destructor called for " << _name << std::endl;
    }
};


class SmartPhone : public Phone {
public:
    void MakeCall() {
        std::cout << "Inside smart Phone\n";
    }
};
#endif // PHONE_H
