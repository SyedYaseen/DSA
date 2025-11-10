#include <bits/stdc++.h>
using namespace std;

void dfs(int c, vector<vector<char>> &board, int &res, unordered_set<int> &rows, unordered_set<int> &pd, unordered_set<int> &nd)
{
    if (c == 8)
    {
        res++;
    }

    for (int r = 0; r < 8; r++)
    {
        if (rows.count(r) || pd.count(r - c) || nd.count(r + c) || board[r][c] == '*')
            continue;

        rows.insert(r);
        pd.insert(r - c);
        nd.insert(r + c);
        dfs(c + 1, board, res, rows, pd, nd);
        rows.erase(r);
        pd.erase(r - c);
        nd.erase(r + c);
    }
}

int main()
{
    vector<vector<char>> board(8, vector<char>(8, '.'));
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            cin >> board[i][j];
        }
    }
    int res = 0;
    unordered_set<int> rows;
    unordered_set<int> pd;
    unordered_set<int> nd;

    dfs(0, board, res, rows, pd, nd);
    cout << res;

    return 0;
}
