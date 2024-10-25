
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

    while (a > 0)
    {

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
            cout << d << "\n";
        else
        {
            
            if (max & 0b1)
                cout << d + (c - r) << "\n";

            else
                cout << d - (c - r) << "\n";
        }
        a--;
    }
}
