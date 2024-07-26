#pragma once
class Solution {
public:

    int traverse(TreeNode* root, bool& res) {
        if (!root) return true;

        int left = traverse(root->left, res);
        int right = traverse(root->right, res);
        res = std::abs(left - right) <= 1;

        return 1 + std::max(left, right)
    }

    bool isBalanced(TreeNode* root) {
        if (!root) return true;
        bool res = true;

        traverse(root, res);
        return res;
    }
};