#pragma once

#include <iostream>
using namespace std;
class Solution {
public:
    // Iterate until we find a open bracket
    // Go back until we determine the number of digits and calc the actual value of the digits
    // Determine the correct closing bracket by iterating using the counter
    // Decode the string
    // Merge the decoded substring into middle by cutting the front and back of the actual string
    // Set the iterator for the next round(end) before the location of brackets - so it can deal with nested brackets
    string decodeString(string s) {
        int start = 0;
        int end = 0;
        int brack = 0;
        int numDigits = 0;
        int iter = 0;
  
        string patch = "";
        while (end < 0 || end < s.size()) {

            if (end > 0 && s[end] == '[') {
                    
                // Find number of digits
                start = end - 1; // using the same start to calcualte the no of digits
                while (start >= 0 && isdigit(s[start])) {
                    iter = atoi(&s[start]);
                    start--;
                }
                numDigits = end - start - 1;
                
                // Find nested brackets
                start = end; // Assign to start of brackets so its used later
                brack = 1;
                end++;
                while (brack != 0) {
                    if (s[end] == ']') brack--;
                    if (s[end] == '[') brack++;
                    end++;
                }

                string toDecode = s.substr(start + 1, end - start - 2);

                while (iter > 0) {
                    patch += toDecode;
                    iter--;
                }

                s = s.substr(0, start - numDigits) + patch + s.substr(end);
                end = start - 2;
                patch = "";

                numDigits = 0;
                continue;
            }
            
            end++;
        }
        return s;
    }
};