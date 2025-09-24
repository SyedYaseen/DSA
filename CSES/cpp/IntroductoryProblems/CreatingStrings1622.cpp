#include <bits/stdc++.h>
using namespace std;

void backtrack(string curr, string &s, vector<bool> &visited, vector<string> &res)
{
    if (curr.length() == s.length())
    {
        res.push_back(curr);
        return;
    }

    for (int i = 0; i < s.length(); i++)
    {
        if (visited[i])
            continue;
        if (i > 0 && s[i] == s[i - 1] && visited[i - 1] == false) // In future iterations visited[i - 1] == false filters out duplicate coming in as first char, e.g. in a a b, the second a should not come in the first chosen char. So this condition says that dont choose a duplicate 'a' when an 'a' befire that isnt chosen.
            continue;

        curr += s[i];
        visited[i] = true;
        backtrack(curr, s, visited, res);
        visited[i] = false;
        curr.pop_back();
    }
}

int main()
{
    string s = "aba";
    // cin >> s;
    sort(s.begin(), s.end());
    vector<bool> visited(s.length(), false);
    vector<string> res;
    backtrack("", s, visited, res);

    cout << res.size() << "\n";
    for (auto &i : res)
    {
        cout << i << "\n";
    }

    return 0;
}
