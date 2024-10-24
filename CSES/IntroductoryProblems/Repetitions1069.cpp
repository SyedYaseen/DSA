#include <bits/stdc++.h>

using namespace std;
void setIO(string name)
{
    ios_base::sync_with_stdio(0);
    cin.tie(0);
    freopen(("../tests/IntroductoryProblems/Repetitions1069/" + name + ".in").c_str(), "r", stdin);
}

int main()
{
    setIO("2");

    string a;
    unsigned int i = 0, j = 0, max = 0;
    cin >> a;

    while (j < a.size())
    {
        if (a[i] == a[j])
        {
            j++;
            if (j - i + 1 > max)
                max = j - i + 1;
        }
        else
        {
            i = j;
        }
    }

    cout << max - 1;
}
