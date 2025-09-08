#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

int main()
{
    setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/NumberSpiral1071/1.in");

    long long int diag, max, diff, x, y;
    cin >> x;

    while (cin >> x && cin >> y)
    {
        max = x > y ? x : y;
        diag = (max * (max - 1)) + 1;
        diff = x - y;

        if (max & 0b1)
        {
            cout << diag - diff << "\n";
        }
        else
        {
            cout << diag + diff << "\n";
        }
    }

    return 0;
}
