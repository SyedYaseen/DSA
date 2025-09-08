#include <bits/stdc++.h>
using namespace std;
typedef long long ll;
int main()
{
    ll n = 7;
    ll r = 0;

    for (int i = 1; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            r++;
            if (i != n / i)
                r++;
        }
    }

    cout << r;
}