#include <bits/stdc++.h>

using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen((name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("./tests/002/10");

    unsigned long long n, a;
    cin >> n;
    unsigned long long sum;
    sum = n * (n + 1);
    sum >>= 1;

    while (cin >> a)
    {
        sum -= a;
    }

    cout << sum;
}
