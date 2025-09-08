#include <bits/stdc++.h>
#include "../helper.h"
using namespace std;

int main()
{
    setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/MissingNumber1083/3.in");

    unsigned long long int n, a, sum;
    cin >> n;

    sum = n * (n + 1);
    sum >>= 1;
    while (cin >> a)
    {
        sum -= a;
    }

    cout << sum << "\n";
}
