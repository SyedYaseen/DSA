#include "../../imports.h"

class Solution {
public:

    void dfs(int row, int col, vector<vector<char>>& board) {
        if (row < 0 || col < 0 || row > board.size() - 1 || col > board[0].size() - 1 || board[row][col] == 'T' || board[row][col] == 'X') return;
        
        if (board[row][col] == 'O') {
            board[row][col] = 'T';
        }
    
        dfs(row - 1, col, board);
        dfs(row + 1, col, board);
        dfs(row, col - 1, board);
        dfs(row, col + 1, board);        
    }

    void solve(vector<vector<char>>& board) {    

        int i = 0;    
        for (i = 0; i < board[0].size(); i++) {
            
            dfs(0, i, board); // Top
            dfs(board.size() - 1, i, board); // Bottom
        }
        
        for (i = 1; i < board.size() - 1; i++) {
            dfs(i, 0, board); // Left
            dfs(i, board[0].size() - 1, board); // Right
        }

        for (i=0; i< board.size(); i++) {
            for (int j = 0; j < board[0].size(); j++) {
                if (board[i][j] == 'T') 
                    board[i][j] = 'O';
                
                else if (board[i][j] == 'O') 
                    board[i][j] = 'X';
            }
        }
    }
};

int main2() {
    Solution s;


    vector<vector<char>> t2 {
        {'O','X','X','O','X'},
        {'X','O','O','X','O'},
        {'X','O','X','O','X'},
        {'O','X','O','O','O'},
        {'X','X','O','X','O'}        
        };


    s.solve(t2);
        // out
        // ["O","X","X","O","X"],
        // ["X","X","X","X","O"],
        // ["X","X","X","X","X"],
        // ["O","X","O","O","O"],
        // ["X","X","O","X","O"]
        // exp
        // ["O","X","X","O","X"],
        // ["X","X","X","X","O"],
        // ["X","X","X","O","X"],
        // ["O","X","O","O","O"],
        // ["X","X","O","X","O"]

    // vector<vector<char>> t1 {
    //     {'X','X','X','X'},
    //     {'X','O','O','X'},
    //     {'X','X','O','X'},
    //     {'X','O','X','X'}
    //     };
    return 0;

}