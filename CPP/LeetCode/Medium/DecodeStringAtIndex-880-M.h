using namespace std;
#include <iostream>
class Solution {
public:
    string decodeAtIndex(string s, int k) {

        int i = 0;
        int tempEnd = 0;
        string patch;
        string res = "";
        while (i < s.size()) {
            if (k - 1 <= i && !isdigit(s[i])) {
                res = s[k - 1];
                // cout << "If case: " << s;
                return res;
            }

            if (isdigit(s[i])) {
                int iter = s[i] - '0';
                // cout << "Iteration: " << iter << endl;
                patch = s.substr(0, i);
                string temp = patch;


                tempEnd = i * iter;
                // cout << "Patch before iter: " << patch << endl;

                while (iter > 1) {
                    patch += temp;
                    iter--;
                }
                // cout <<  "Patch after iter: " << patch <<endl;
                // cout << "substr: " << s.substr(i+1) << endl;
                s = patch + s.substr(i + 1);
                // cout << "After combining: " << s << endl;;

                i = tempEnd;
                patch = "";
                continue;
            }
            i++;
        }

        if (res == "") {
            res = s[k - 1];
            // cout << "If case: " << s;
            return res;
        }


        return res;
    }
};