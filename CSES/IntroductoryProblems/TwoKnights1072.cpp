
#include <bits/stdc++.h>
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen(("../tests/IntroductoryProblems/TwoKnights1072/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("1");
    long long int k = 5;
    // cin >> k;

    long long int total = 0;
    long long int atkPos = 0;

    for (int n = 1; n <= k; n++)
    {
        // Combination: nSqr * (nSqr -1) / # of options
        total = (n * n) * ((n * n) - 1) >> 1;

        // For each n sized board, the attack pattern (2x3) can be moved n-1 and there are two attacks that can happen on each pattern, multiplied by (3x2) which can be moved (n-2) times.
        atkPos = (n - 1) * (n - 2) << 2;
        cout << n << " : " << total - atkPos << "\n";
    }
}
