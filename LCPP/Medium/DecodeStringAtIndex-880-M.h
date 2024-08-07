using namespace std;
#include "../imports.h"

//s.decodeAtIndex("leet2code3", 10);
 //s.decodeAtIndex("a23bc23", 42);
 /*s.decodeAtIndex("a2b3c4d5e6f7g8h9", 10);*/
// s.decodeAtIndex("ha22", 5);
 // s.decodeAtIndex("y959q969u3hb22odq595", 222280369);
 // s.decodeAtIndex("gl2sld3935dz5wx5r64x", 1392818);
 //s.decodeAtIndex("a2345678999999999999999", 1);
 //s.decodeAtIndex("a23b23", 41);

class Solution {
public:

    string decodeAtIndex(string s, int k) {
        int len = 0;
        int i = 0;
        string res = "";
        while (len < k) {
            if (isdigit(s[i])){ 
                int d = s[i] - '0';
                len*=d;
            } 
            else len=i;
            i++;
        }

        while (k <= len) {
            if (isdigit(s[len])) {
                int d = s[len] - '0';
                k%=len;
            } 
            else {
                if (k == 0 || k ==len) {
                    res = s[len]; break;
                }
                len--;
            }

        }

        return res;

    }


    //  Not working too complicated
    string decodeAtIndex3(string s, int k) {
        string res = "";
        int i = 0;
        int start=0;
        vector<long> iters;
        vector<long> numChars;
        vector<string> items;
        long long totalChars=0;

        
        // Split words and reps until the total characters 
        while (i < s.size() && totalChars < k) {
            int iter = s[i] - '0';

            if (isdigit(s[i])) {
                if (numChars.empty()) {
                 numChars.push_back(i);
                 totalChars=i*iter;
                 items.push_back(s.substr(0, i));
                }
               else {
                numChars.push_back((iters.back()*numChars.back())+ i-start);
                totalChars=numChars.back()*iter;

                if (start == i) items.push_back(items.back());
                else  items.push_back(s.substr(start, i-start));
               
               }

               
               iters.push_back(iter);                
               start=i+1;  
            }
            i++;
        }

        if (iters.empty()) {res = s[k-1]; return res;}

        int resK = k % numChars.back() - 1;
        if (!resK) resK = 1;

        for (i = 0; i < numChars.size(); i++) {
            
            if (resK > iters[i] * numChars[i]) {
                resK-= (iters[i] * numChars[i]);
            }
            else {

                if (resK > items[i].size()) resK = items[i].size() % resK;
                res = items[i][resK-1];
                break;
            }
        }
        return res;
    }

    //Naive soln doesnt work
    string decodeAtIndex2(string s, int k) {

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