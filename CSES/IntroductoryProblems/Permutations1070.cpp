#include <bits/stdc++.h>
#include <queue>
using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen(("../tests/IntroductoryProblems/Permutations1070/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("10");
    unsigned int n, l;
    cin >> n;
    n = 4;

    if (n == 1)
    {
        cout << 1;
        return 0;
    }
    if (n > 1 && n < 4)
    {
        cout << "NO ANSWER";
        return 0;
    }

    while (n > 0)
    {
        if (n % 2)
            cout << n << " ";
        n--;
    }

    while (l > 0)
    {
        if (!(l % 2))
            cout << l << " ";
        l--;
    }
}

/*
int main()
{
    setIO("10");
    unsigned int n, l;
    cin >> n;

    if (n > 1 && n < 4)
    {
        cout << "NO SOLUTION";
        return 0;
    }
    if (n == 4)
    {
        cout << 2 << " " << 4 << " " << 1 << " " << 3 << " ";
        return 0;
    }

    l = n;
    cout << n;
    n--;

    queue<unsigned int> q;
    for (; n > 0; n--)
    {
        if (l == n + 1)
        {
            q.push(n);
        }
        else
        {
            l = n;
            cout << n;
        }
    }

    while (!q.empty())
    {
        cout << q.front();
        q.pop();
    }
}
*/