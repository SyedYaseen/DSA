#include <vector>
#include <iostream>
using namespace std;

/*
* Findings
* 
* 1. We can't have ')' before '('
* 2. We can have max n number of '(' and ')'
* 
* Pseudo
* 1. Recursive backtracking problem
* 2. Create two variables open and close
* 3. Open - Tracks # of '(' on call stack
* 4. Close - Tracks # of  ')' on call stack
* 5. If open < n, we can add '('
* 6. If open > close, we can add ')'
* 7. Once n == open == close we have a valid set
* 8. Add valid set to result list
* 9. Important: After each valid set, pop the last bracket
*/
//n =2 


class Solution {
public:
    vector<string> res;
    string p;

    void backTrack(int open, int close, int &n) {
        // Base case
        if (open == n && close == n) {
            res.push_back(p);
            return;
        }

        // Add '(' only if open < n
        if (open < n) {
            p.push_back('(');
            backTrack(open + 1, close, n);
            p.pop_back();
        }
 
        // Add ')' only if open > close
        if (open > close) {
            p.push_back(')');
            backTrack(open, close + 1, n);
            p.pop_back();
        }
    }

    vector<string> generateParenthesis(int n) {
        backTrack(0, 0, n);
        return res;
    }
};

