// #pragma once
// PacificAtlanticWaterFlow-417-M
#include "../../imports.h"

class Solution {
public:
    vector<vector<int>> res;
    int margin;


    bool dfs(vector<vector<int>>& h, int row, int col, int previous, bool atlantic) {
        if (atlantic) {
            if (row > margin || col > margin) return true;
        } else {
            if (row < 0 || col < 0) return true;
        }

        if (h[row][col] > previous) return false;

        

        h[row][col] = -1;
        
        if (
            (dfs(heights, row - 1, col, heights[row][col]) || dfs(heights, row, col - 1, heights[row][col])) &&
            (dfs(heights, row + 1, col, heights[row][col]) || dfs(heights, row, col + 1, heights[row][col])))
        {
            res.push_back(vector<int> {row, col});
        }
        return;
    }

    vector<vector<int>> pacificAtlantic(vector<vector<int>>& heights) {
        margin = heights.size() - 1;


        vector<vector<int>> h =  heights;
        dfs(h, 0,  0, h[0][0], true);





        return res;
    }
};

int main2() {
    Solution s;
    auto t1 = vector<vector<int>>{ {1, 2, 2, 3, 5},{3, 2, 3, 4, 4},{2, 4, 5, 3, 1},{6, 7, 1, 4, 5},{5, 1, 1, 2, 4} };
    s.pacificAtlantic(t1);

    return 0;

}