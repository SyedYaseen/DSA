#pragma once
#include "../imports.h"

class Solution {
public:
    int max = 0;
    int current = 0;
    void dfs(int row, int col, vector<vector<int>>& grid) {
        if (row < 0 || col < 0) return;
        if (row >= grid.size() || col >= grid[0].size()) return;
        if (grid[row][col] == -1) return;

        if (grid[row][col] == 0) {
            grid[row][col] = -1;
            return;
        }
        grid[row][col] = -1;
        current++;
        
        dfs(row - 1, col, grid);
        dfs(row + 1, col, grid);
        dfs(row, col - 1, grid);
        dfs(row, col + 1, grid);
    }

     int maxAreaOfIsland(vector<vector<int>>& grid) {
        for (int i = 0; i < grid.size(); i++) {
            for (int j = 0; j < grid[0].size(); j++) {
                if (grid[i][j] == 1) {
                    dfs(i, j, grid);
                    if (current > max) max = current;
                    current = 0;
                }
            }
        }

        return max;
    }
};
