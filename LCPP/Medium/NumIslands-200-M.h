#pragma once
#include "../imports.h"

class Solution {
public:
    // with existing grid -  beat 83%
    int numIslands(vector<vector<char>>& grid) {
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