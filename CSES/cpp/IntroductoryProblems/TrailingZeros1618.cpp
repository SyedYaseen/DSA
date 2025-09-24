#include <bits/stdc++.h>
using namespace std;

int main()
{
    long long int n;
    cin >> n;
    long long int fivepow = 5;
    long long int res = 0;
    while (n >= fivepow)
    {
        res += n / fivepow;
        fivepow *= 5;
    }
    cout << res;

    return 0;
}
