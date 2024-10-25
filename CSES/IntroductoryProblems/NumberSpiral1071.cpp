
#include <bits/stdc++.h>
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen(("../tests/IntroductoryProblems/NumberSpiral1071/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("1");

    long long int max, a, r, c, d;
    bool rLow = false; // Setting row as highest among two inputs
    cin >> a;
    cin >> r;
    cin >> c;

    max = r;

    // Calc max value among r, c
    // Setting rLow based on actual input
    if (r < c)
    {
        max = c;
        rLow = true; // setting row as lowest
    }

    d = (max * max) - (max - 1); // value at diagonal

    if (r == c)
        cout << d;
    else if (rLow)
    {
        // If odd
        // r inc from d
        // c dec from d
        if (max & 0b1)
            cout << d + (c - r);

        else
            cout << d - (c - r);
    }
    else if (!rLow)
    {
        if (max & 0b1)
            cout << d - (r - c);

        else
            cout << d + (r - c);
    }
}
