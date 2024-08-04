#include "../imports.h"
class Solution {
public:
    string countAndSay(int n) {
        if (n == 1) return "1";
        if (n == 2) return "11";

        string s = "21";
        string temp = "";

        int i = 0;
        int j = 0;

        while (n > 3) {
            while (j <= s.size()) {
                if (s[i] == s[j]) j++;
                else if (s[i] != s[j]) {
                    temp += (to_string(j - i) + s[i]);
                    i = j;
                }
            }
            s = temp;
            temp = "";
            i = 0;
            j = 0;
            n--;
        }


        return s;
    }
};