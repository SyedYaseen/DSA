#include "../../imports.h"

class Solution {
public:
    string removeDuplicateLetters(string s) {
        if (s.size() == 1) return s;
        unordered_map<char, int> m;
        unordered_map<char, int> curr;
        string res;
        string temp;
        

        for (int i = s.size() - 1; i>=0;i--) {
            if(!m.contains(s[i])) m[s[i]]=i;
        }

        res = s[0];
        curr[s[0]] = 0;


        for (int i = 1; i< s.size(); i++) {
            char last = res.back();

            if ((last > s[i] && m[last] > i)) {
                // remove from res and set
                curr.erase(res.back());
                res[res.size() -1] = s[i];
                curr[s[i]] = res.size() -1;
            }

            else if (curr.contains(s[i])) {
                res.erase(curr[s[i]], 1);
                res.push_back(s[i]);
                curr[s[i]] = res.size() - 1;
            }
            
            else {
                res.push_back(s[i]);
                curr[s[i]] = res.size() - 1;
            }
        }

        return res;
    }
};

int main () {
    Solution s;
    // s.removeDuplicateLetters("bcabc");
    s.removeDuplicateLetters("cbacdcbc");
    
}