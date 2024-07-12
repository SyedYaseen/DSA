#pragma once
#include "Tree.h"
using namespace std;
class Solution {
public:

    int traverse(TreeNode* root, int& res) {
        int left = traverse(root->left, res);
        int right = traverse(root->right, res);
        res = std::max(res, left+right);
        return 1 + std::max(left, right);
    }

    int diameterOfBinaryTree(TreeNode* root) {
        int res = 0;
        traverse(root, res);
        return res;
    }
};