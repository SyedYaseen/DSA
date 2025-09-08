#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

int main()
{
    setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/Repetitions1069/4.in");

    string t;
    cin >> t;

    char prev = t[0];
    long long int res = 1, curr = 1;

    for (int i = 1; i < t.length(); i++)
    {
        if (prev == t[i])
        {
            curr++;
        }
        else
        {
            if (res < curr)
            {
                res = curr;
            }
            curr = 0;
            prev = t[i];
        }
    }

    if (res < curr)
    {
        res = curr;
    }

    cout << res << "\n";

    return 0;
}
