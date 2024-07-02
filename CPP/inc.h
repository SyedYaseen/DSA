#pragma once
void incByValue(int val) {
    val++;
}

void incByReference(int* ptrVal) {
    ++(*ptrVal);
}

void incByReferenceCorrectWay(int& val) { // This is much cleaner since when calling this method, we pass the value directly instead of a pointer, but the argument is a referece
    ++val;
}