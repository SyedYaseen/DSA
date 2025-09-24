#include <bits/stdc++.h>
// #include "../helper.h"
using namespace std;
const long long MOD = 1e9 + 7;

int binexp(long long int base, long long int exp)
{
    if (exp == 0)
        return 1;

    long long int res = binexp(base, exp / 2);
    res = (res * res) % MOD;

    if (exp & 0b1)
        res = (res * base) % MOD;

    return res;
}

int main()
{
    // setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/BitStrings1617/2.in");
    long long int n;
    cin >> n;
    cout << binexp(2, n);
    return 0;
}
