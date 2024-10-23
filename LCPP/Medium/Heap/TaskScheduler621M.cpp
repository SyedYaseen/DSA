#include "../../imports.h"

class Compare
{
public:
    bool operator()(pair<char, int> &lhs, pair<char, int> &rhs)
    {
        return lhs.second < rhs.second;
    }
};

class Solution
{
public:
    int leastInterval(vector<char> &tasks, int n)
    {

        priority_queue<pair<char, int>> q;
        int fq[26]{};
        for (int i = 0; i < tasks.size(); i++)
        {
            fq[tasks[i] - 65] += 1;
        }
        pair<char, int> p;
        for (int i = 0; i < 26; i++)
        {
            if (fq[i] != 0)
            {
                p.first = i + 65;
                p.second = fq[i];
                q.push(p);
            }
        }

        int res = 0;
        while (!q.empty())
        {
            pair<char, int> curr = q.top();
            q.pop();
            int gaps = (curr.second - 1) * n;
            res += curr.second + gaps;

            int gapCount = n;
            char prev = '!';
            while (!q.empty() && n > 0 && gaps > 0 && prev != q.top().first)
            {
                pair<char, int> innerCurr = q.top();
                prev = innerCurr.first;
                q.pop();

                if (gapCount < innerCurr.second)
                {
                    innerCurr.second -= gapCount;
                    q.push(innerCurr);
                }
                else if (gapCount == innerCurr.second) // if gapcount >= available items
                {
                    innerCurr.second = 1;
                    q.push(innerCurr);
                }
                gaps -= innerCurr.second;
            }
        }

        return res;
    }
};

int main()
{
    Solution s;
    vector<char> tasks{'A', 'A', 'A', 'B', 'B', 'B'};
    s.leastInterval(tasks, 3);
}
