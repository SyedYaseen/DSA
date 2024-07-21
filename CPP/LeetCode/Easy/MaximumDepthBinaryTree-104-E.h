#pragma once
#include "Tree.h"
#include <queue>
using namespace std;
class Solution {
public:
    // BFS
    int maxDepth(TreeNode* root) {
        if (!root) return 0;
        int res = 0;
        std::queue<TreeNode*> q;
        q.push(root);

        while (!q.empty()) {
            int sz = q.size();
            res++;
            for (int i = 0; i < sz; i++)
            {
                TreeNode* node = q.front(); q.pop();
                if (node->left) q.push(node->left);
                if (node->right) q.push(node->right);
            }
        }
        return res;
    }

    //// Recursive DFS
    //int maxDepth(TreeNode* root) {
    //    if (!root) return 0;
    //    return 1 + std::max(
    //        maxDepth(root->left), 
    //        maxDepth(root->right));
    //}
};