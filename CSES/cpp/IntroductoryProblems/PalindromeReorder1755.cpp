#include <bits/stdc++.h>
using namespace std;

int main()
{
    string s;
    cin >> s;
    int fq[26] = {};
    for (char c : s)
    {
        fq[c - 65]++;
    }
    string res;
    char odd = '\0';

    int i = 0;
    for (; i < 26; i++)
    {
        if (fq[i] & 0b1)
        {
            if (odd != '\0')
            {
                cout << "NO SOLUTION";
                return 0;
            }
            else
            {
                fq[i]--;
                odd = (char)65 + i;
            }
        }

        if (fq[i] == 0)
            continue;

        for (int j = 0; j < fq[i] / 2; j++)
        {
            res += (char)65 + i;
        }
    }

    s = "";
    i = res.size() - 1;
    for (; i >= 0; i--)
    {
        s += res[i];
    }

    if (odd != '\0')
    {
        res += odd;
    }

    cout << res + s << "\n";

    return 0;
}
