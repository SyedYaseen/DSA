#include "../imports.h"

class Solution {
public:
    int res = 0;
    int current = 0;

    int orangesRotting(vector<vector<int>>& grid) {
        queue<pair<int, int>> q;
        pair<int, int> current;
        pair<int, int> neighbour;
        vector<pair<int, int>> neighbours = { {-1, 0}, {1, 0}, {0, -1}, {0, 1} };
        vector<pair<int, int>> badOranges;
        int freshOranges = 0;
        int distance = 0;

        // Get all rotten oranges
        for (int i = 0; i < grid.size(); i++) {
            for (int j = 0; j < grid[0].size(); j++) {
                if (grid[i][j] == 2) {
                    // Mark are neigh as negtive of counter value
                    grid[i][j] = -1;
                    badOranges.push_back(pair<int, int> {i, j});
                }
                if (grid[i][j] == 1) freshOranges++;

            }
        }

        if (freshOranges == 0) return 0;
        if (badOranges.empty()) return -1;

        // Start bfs with each of the rotten oranges
        // If keep track of current depth
        // If neigh is good orange, set that value to depth, if depth is lesser than current, also change result depth that was the same
        // If neigh is bad oranage, return
        // If neigh is empty return and set a visited value on it
        // Check at end if all items are covered, if there are good oranges still, return -1

        for (pair<int, int> badOrange : badOranges) {

            q.push(badOrange);
            distance = -1;

            while (!q.empty()) {
                current = q.front();

                distance = grid[current.first][current.second];
                if (distance > 0) distance = -1;
                q.pop();
                for (auto n : neighbours) {
                    neighbour.first = current.first + n.first;
                    neighbour.second = current.second + n.second;

                    // Check margin
                    if (neighbour.first < 0 || neighbour.second < 0) continue;
                    if (neighbour.first >= grid.size() || neighbour.second >= grid[0].size()) continue;
                    if (grid[neighbour.first][neighbour.second] == 9) continue; // Already visited empty


                    // If good orange thats being visited the first time or previously visited, mark the distance - 1
                    // If the orange was previously visited by another iteration and its distance is lesser (in this case higher, since its negative)  then replace it and add to q. Else dont
                    if (grid[neighbour.first][neighbour.second] == 1 || grid[neighbour.first][neighbour.second] < distance - 1) {
                        grid[neighbour.first][neighbour.second] = distance - 1;
                        q.push(neighbour);
                    }

                    // If empty box, mark as visited
                    if (grid[neighbour.first][neighbour.second] == 0)
                        grid[neighbour.first][neighbour.second] = 9;

                }
            }
        }

        distance = 0;
        for (int i = 0; i < grid.size(); i++) {
            for (int j = 0; j < grid[0].size(); j++) {
                if (grid[i][j] == 1) return -1;
                if (grid[i][j] != 9 && grid[i][j] < distance) distance = grid[i][j];

            }
        }

        return (distance + 1) * -1;

    }
};