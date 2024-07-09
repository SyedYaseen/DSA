#include <vector>
#include <iostream>
#include <stack>
using namespace std;

class Solution {
public:
    vector<string> generateParenthesis(int n) {
        vector<string> res;
        stack<char> p;

        // 
        while (n>0) {

            for (int i = n; i >= 0; i--) {
                p.push('(');


            }



            n--;

        }

        return res;

    }
};

