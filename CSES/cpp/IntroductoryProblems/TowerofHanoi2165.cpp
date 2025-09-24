#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

void recur(int n, char a, char b, char c)
{
    if (n == 1)
    {
        cout << a << " " << c << "\n";
        return;
    }

    recur(n - 1, a, c, b);
    cout << a << " " << c << "\n";
    recur(n - 1, b, a, c);
}

int main()
{
    int n = 3;
    recur(n, '1', '2', '3');

    return 0;
}
