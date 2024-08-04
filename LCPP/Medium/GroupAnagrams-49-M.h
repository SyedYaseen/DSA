#pragma once
#include "../imports.h"
class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> m;
        vector<vector<string>> res;
        string sortedStr;
        for (string item : strs) {
            sortedStr = item;

            sort(sortedStr.begin(), sortedStr.end());

            if (m.contains(sortedStr)) {
                m[sortedStr].push_back(item);
            } else m.insert(sortedStr, { item });
        } 
        for (auto item : m) {
            res.push_back(item.second);
        }
        delete &m;
        return res;
    }
};