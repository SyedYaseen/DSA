#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

int main()
{
    setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/IncreasingArray1094/6.in");
    long long int prev, curr, res = 0;
    cin >> prev;

    cin >> prev;

    while (cin >> curr)
    {
        if (curr < prev)
        {
            res += prev - curr;
        }
        else
        {
            prev = curr;
        }
    }

    cout << "res: " << res << "\n";
}
