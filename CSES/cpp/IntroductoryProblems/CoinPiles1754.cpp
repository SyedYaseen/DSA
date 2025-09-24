#include <bits/stdc++.h>
// #include "../helper.h"
using namespace std;

int main()
{
    // setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/CoinPiles1754/1.in");

    int n;
    cin >> n;
    int a, b;
    while (cin >> a && cin >> b)
    {
        if ((a + b) % 3 == 0 && min(a, b) * 2 >= max(a, b))
        {
            cout << "YES" << "\n";
        }
        else
        {
            cout << "NO" << "\n";
        }
    }

    return 0;
}
