#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

int main()
{
    setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/WeirdAlgorithm1068/1.in");

    unsigned long long int a, n;
    cin >> n;

    while (n != 1)
    {
        cout << n << "\n";

        if (n & 0b1)
        {
            a = n;
            n <<= 1;
            n += a + 1;
        }
        else
        {
            n >>= 1;
        }
    }

    cout << n << "\n";

    return 0;
}
