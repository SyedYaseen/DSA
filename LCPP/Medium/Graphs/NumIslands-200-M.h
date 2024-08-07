#pragma once
#include "../imports.h"

//vector<vector<char>> t1 {
//	{'1', '1', '1', '1', '0'},
//	{'1', '1', '0', '1', '0'},
//	{'1', '1', '0', '0', '0'},
//	{'0', '0', '0', '0', '0'}
//};

//vector<vector<char>> t2{
//{'1', '1', '0', '0', '0'},
//{'1', '1', '0', '0', '0'},
//{'0', '0', '1', '0', '0'},
//{'0', '0', '0', '1', '1'}
//};
//
//vector<vector<char>> t3{
//    {'1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '0', '1', '1'},
//    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '0'},
//    {'1', '0', '1', '1', '1', '0', '0', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '0', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1'},
//    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '0', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '0', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'0', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1'},
//    {'1', '0', '1', '1', '1', '1', '1', '0', '1', '1', '1', '0', '1', '1', '1', '1', '0', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '1', '1', '0'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '1', '1', '1', '1', '0', '0'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
//    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'} };
//
//s.numIslands(t2);


class Solution {
public:

    void dfs(int row, int col, vector<vector<char>>& grid) {
        if ((row < 0 || col < 0 || row >= grid.size() || col >= grid[0].size()) || grid[row][col] == '\0') return;
        
        if (grid[row][col] == '0') {
            grid[row][col] = '\0';
            return;
        }

        grid[row][col] = '\0';

        dfs(row - 1, col, grid);
        dfs(row + 1, col, grid);
        dfs(row, col - 1, grid);
        dfs(row, col + 1, grid);

    }

    // dfs with existing grid better than dfs for this case
    int numIslands(vector<vector<char>>& grid) {

        int res = 0;

        for (int i = 0; i < grid.size(); i++) {
            for (int j = 0; j < grid[0].size(); j++) {

                if (grid[i][j] == '1') {
                    res++;
                    dfs(i, j, grid);
                }
                else grid[i][j] = '\0';
            }
        }

        return res;
    }



    // bfs with existing grid -  beat 83%
    int numIslandsBfs(vector<vector<char>>& grid) {
        int row = grid.size();
        int col = grid[0].size();

        queue<pair<int, int>> q;
        pair<int, int> curr;
        int res = 0;

        vector<pair<int, int>> neighbours = { {-1, 0}, {1, 0}, {0, -1}, {0, 1} };

        pair<int, int> p;

        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {

                if (grid[i][j] == '1') {
                    curr.first = i;
                    curr.second = j;
                    grid[i][j] = '\0';
                    q.push(curr); // come back later to directly add itr
                    res++;

                    //bfs
                    while (!q.empty()) {
                        curr = q.front();
                        q.pop();

                        for (pair<int, int> n : neighbours) {
                            p.first = curr.first + n.first;
                            p.second = curr.second + n.second;

                            if (p.first >= 0 && p.first < row && p.second >= 0 && p.second < col && // check bounds
                                grid[p.first][p.second] != '\0' &&
                                grid[p.first][p.second] == '1') {
                                q.push(p); grid[p.first][p.second] = '\0';
                            }
                        }
                    }

                }
                else grid[i][j] = '\0';
            }
        }

        return res;
    }


    // Super slow and beat only 5%
    //int numIslandsWithSet(vector<vector<char>>& grid) {
    //    int row = grid.size();
    //    int col = grid[0].size();

    //    queue<pair<int, int>> q;
    //    set<pair<int, int>> s;

    //    pair<int, int> curr;
    //    int res = 0;

    //    vector<pair<int, int>> neighbours = { {-1, 0}, {1, 0}, {0, -1}, {0, 1} };

    //    pair<int, int> p;

    //    for (int i = 0; i < row; i++) {
    //        for (int j = 0; j < col; j++) {
    //            curr.first = i;
    //            curr.second = j;
    //            
    //            if (!s.contains(curr) && grid[i][j] == '1') {
    //                q.push(curr); 
    //                res++;

    //                //bfs
    //                while (!q.empty()) {
    //                    curr = q.front();
    //                    q.pop();

    //                    for (pair<int, int> n : neighbours) {
    //                        p.first = curr.first + n.first;
    //                        p.second = curr.second + n.second;
    //                        
    //                        if (p.first >= 0 && p.first < row && p.second >= 0 && p.second < col && // check bounds
    //                            !s.contains(p) &&
    //                            grid[p.first][p.second] == '1') {
    //                            q.push(p); s.insert(p);
    //                        }
    //                    }
    //                }
    //                
    //            } else s.insert(curr);
    //        }
    //    }

    //    return res;
    //}
};