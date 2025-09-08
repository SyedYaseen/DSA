#include <bits/stdc++.h>
// #include "../helper.h"
using namespace std;

int main()
{
    // setIO("/home/uggi/projects/DSA/CSES/tests/IntroductoryProblems/Permutations1070/6.in");

    int n, a;
    cin >> n;

    if (n <= 3 && n > 1)
        cout << "NO SOLUTION";
    else if (n == 4)
        cout << "2 4 1 3";

    else
    {

        a = n;

        while (a > 0)
        {
            cout << a << " ";
            a -= 2;
        }

        n--;
        while (n > 0)
        {
            cout << n << " ";
            n -= 2;
        }
    }
}
