#pragma once
#include <iostream>
using namespace std;
class Solution {
public:

    string decodeString(string s) {
        string res = "";
        int start = 0;
        int end = 0;
        int brack = 0;
        int iter = 0;
        string patch = "";
        while (end < s.size()) {
            if (s[end] == '[') {
                start = end;
                brack = 1;
                iter = int(s[end - 1]) - 48; // weird cpp way to convert char to int

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

                s = s.substr(0, start - 1) + patch + s.substr(end);
                end = start - 2;
                patch = "";
                
                continue;
            }
            end++;
        }



        //for (int i = 0; i < s.size(); i++) {
        //    if (s[i] == '[') {
        //        res += s.substr(prev, prev + i - 2 + 1);
        //        
        //        end = i;
        //        
        //        while (openBracks != 0) {
        //            if (s[end] == '[') openBracks++;
        //            if (s[end] == ']') openBracks--;
        //            end++;
        //        }

        //        cout << s.substr(i, end - i + 1 );


        //        prev = end;
        //        i = end;
        //        //string toDecode = s.substr(i+1, );
        //    }
        //}

        return s;
    }
};