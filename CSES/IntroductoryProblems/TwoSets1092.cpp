
#include <bits/stdc++.h>
#define ll long long
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen(("../tests/IntroductoryProblems/TwoSets1092/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("11");
    long long n = 12;
    // cin >> n;

    ll s = n * (n + 1);
    if (s % 4)
    { // if sum of n numbers ( n(n+1)/2 ) is divisible by 2, then its possible to make two sets
        cout << "NO";
        return 0;
    }

    vector<ll> s1;
    vector<ll> s2;

    ll setSum = s / 4;
    int maxNum = n;
    ll s1Sum = 0;
    cout << "setSum: " << setSum << "\n";

    while (s1Sum != setSum)
    {
        if (maxNum <= (setSum - s1Sum))
        {
            s1.push_back(maxNum);
            s1Sum += maxNum;
            maxNum--;
        }
        else if (maxNum > (setSum - s1Sum))
        {
            s2.push_back(maxNum);
            maxNum--;
        }
    }

    while (maxNum > 0)
    {
        s2.push_back(maxNum);
        maxNum--;
    }

    for (auto &i : s1)
    {
        cout << i << " ";
    }
    cout << "\n";

    for (auto &i : s2)
    {
        cout << i << " ";
    }

    /*
    YES
    4
    1 2 4 7
    3
    3 5 6
    */
}
