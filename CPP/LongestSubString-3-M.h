#pragma once
#include <iostream>  
#include <unordered_set>  
class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        if (s.size() == 0) return 0;
        unordered_set<char> se;
        int res = 0;
        int i = 0;
        int j = 0;

        while (i <= j && j < s.size()) {
            if (!se.count(s[j])) {
                se.insert(s[j]);
                res = std::max(j - i + 1, res);
                j += 1;
            }
            else {
                se.erase(s[i]);
                i += 1;
            }
        }
        return res;
    }
};