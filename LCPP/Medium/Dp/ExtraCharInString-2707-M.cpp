#include "../../imports.h"

class Solution {
public:

    unordered_map<int, int> memo;
    

    int dfs(int index, string& s, set<string>& dict) {
        if (index >= s.size()) return 0;
        if (memo.contains(index)) return memo[index];
        // Assign initial value - this is the maximum extra chars that are possible at any given recursive call
        int res = s.size() - index;

        // Now we increment the sub sequence size and check if it exists in the set
        for (int i = 1; i <= s.size() - index; i++) // i = total size of substring -- s.size() - index E.g. total size = 10 if the index is 4, then the max size of sub seq is 10 - 4 = 6
        {
            if (dict.contains(s.substr(index, i))) {
                res = min(res, dfs(index + i, s, dict)); // The current substr exists, hence no extra characters, as it goes in deeper and once index reaches end, this would return 0
            }
            else {
                res = min(res, i + dfs(index + i, s, dict));
            }
        }
        memo[index] = res;
        return res;
    }



    int minExtraChar(string s, vector<string>& dictionary) {
        set<string> dict (dictionary.begin(), dictionary.end());
        return dfs(0, s, dict);
    }
};

int main() {
    Solution s;
    vector<string> a ({"leet","code","leetcode"});
    int res = s.minExtraChar("leetscode" , a);
    return 0;
}