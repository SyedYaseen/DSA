#pragma once
#include "Tree.h"
class Solution {
public:
    //Max of left, right
    int left = 0;
    int right = 0;
    void Traverse(TreeNode* current, int& side) {
        if (current) side++;
        
        Traverse(current->left, side);
        Traverse(current->right, side);
   
    }

    int maxDepth(TreeNode* root) {
        Traverse(root->left, left);
        Traverse(root->right, right);
        return left > right ? left + 1 : right + 1;
    }
};