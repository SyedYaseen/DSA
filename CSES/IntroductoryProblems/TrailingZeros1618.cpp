
#include <bits/stdc++.h>
using namespace std;
typedef long long ll;

int main()
{
    ll n;
    cin >> n;
    ll r = 0;
    while (n >= 5)
    {
        n /= 5;
        r += n;
    }
    cout << r;
}