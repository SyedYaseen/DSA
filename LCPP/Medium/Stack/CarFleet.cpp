#include "../../imports.h"

class Solution
{
public:
    int carFleet(int target, vector<int> &position, vector<int> &speed)
    {
        int res = 0;

        vector<pair<int, int>> l;
        for (int i = 0; i < position.size(); i++)
        {
            l.push_back(pair{position[i], speed[i]});
        }
        sort(l.begin(), l.end());

        double prev = 0;
        for (int i = l.size() - 1; i >= 0; i--)
        {

            double timeToTarget = double(target - l[i].first) / l[i].second;
            if (timeToTarget > prev)
            {
                prev = timeToTarget;
                res++;
            }
        }

        return res;
    }
};

int main()
{
    Solution s;
    vector<int> pos1{10, 8, 0, 5, 3};
    vector<int> speed1{2, 4, 1, 1, 3};
    // s.carFleet(12, pos1, speed1);  // 3

    vector<int> pos2{0, 2, 4};
    vector<int> speed2{4, 2, 1};
    // s.carFleet(100, pos2, speed2);  // 1

    vector<int> pos3{8, 3, 7, 4, 6, 5};
    vector<int> speed3{4, 4, 4, 4, 4, 4};
    // s.carFleet(10, pos2, speed2);  //

    vector<int> pos4{5, 26, 18, 25, 29, 21, 22, 12, 19, 6};
    vector<int> speed4{7, 6, 6, 4, 3, 4, 9, 7, 6, 4};
    // s.carFleet(31, pos4, speed4); // 6

    vector<int> pos5{8, 3, 7, 4, 6, 5};
    vector<int> speed5{4, 4, 4, 4, 4, 4};
    s.carFleet(10, pos5, speed5); // 6
}