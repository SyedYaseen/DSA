
#include <bits/stdc++.h>
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);

    freopen(("../tests/IntroductoryProblems/IncreasingArray1094/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("6");
    long long unsigned int curr = 0, max = 0, count = 0;
    cin >> curr;

    cin >> curr;
    max = curr;
    while (cin >> curr)
    {
        if (max < curr)
            max = curr;
        if (max > curr)
            count += max - curr;
    }
    cout << count;
}

// g++ -std=c++11 -O2 -Wall IncreasingArray1094.cpp -o test; .\test.exe