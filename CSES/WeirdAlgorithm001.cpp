#include <bits/stdc++.h>

using namespace std;

void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen((name + ".in").c_str(), "r", stdin);
    freopen((name + ".out").c_str(), "w", stdout);
}

void setIO()
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
}

int main()
{
    setIO();

    unsigned long long int n, a;
    cin >> n;

    cout << n << " ";

    while (n != 0b1)
    {
        if (n == 0)
            break;
        if (n & 0b1)
        {
            a = n;
            n <<= 1;
            n += a + 1;
        }
        else
        {
            n >>= 1;
        }
        cout << n << " ";
    }
}
