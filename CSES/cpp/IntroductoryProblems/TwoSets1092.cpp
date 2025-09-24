#include <bits/stdc++.h>
using namespace std;
// #include "../helper.h"

int main()
{
    // setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/WeirdAlgorithm1068/1.in");
    long long int n;
    cin >> n;

    long long int sum = (n * (n + 1)) >> 1;
    if (n == 1 || sum & 0b1)
    {
        cout << "NO";
        return 0;
    }
    long long int n2 = n - 1;

    cout << "YES" << "\n";

    vector<int> rem;
    cout << n / 2 << "\n";
    if (n & 0b1)
    {

        while (n > 3)
        {
            cout << n << " " << n - 3 << " ";
            n -= 4;
        }
        cout << 3;
        cout << "\n"
             << ((n2 + 1) / 2) + 1 << "\n";
    }
    else
    {
        while (n > 0)
        {
            cout << n << " " << n - 3 << " ";
            n -= 4;
        }
        cout << "\n"
             << ((n2 + 1) / 2) << "\n";
    }

    while (n2 > 0)
    {
        cout << n2 << " " << n2 - 1 << " ";
        n2 -= 4;
    }

    return 0;
}
