#include <bits/stdc++.h>
using namespace std;

long long res = LLONG_MAX;
void backtrack(int idx, long long int s1, long long int s2, vector<int> &w)
{
    if (idx == w.size())
    {
        res = min(res, abs(s1 - s2));
        return;
    }

    backtrack(idx + 1, s1 + w[idx], s2, w);
    backtrack(idx + 1, s1, s2 + w[idx], w);
}

int main()
{
    int n;
    cin >> n;
    vector<int> w;

    int t;
    while (cin >> t)
    {
        w.push_back(t);
    }

    sort(w.begin(), w.end());

    backtrack(0, 0, 0, w);

    cout << res;

    return 0;
}
