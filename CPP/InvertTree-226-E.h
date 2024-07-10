#pragma once
#include "Tree.h"
class Solution {

/*
            4

        2       7

      1   3   6   9 
*/

/*
          4

      7       2

    6   9   1   3
*/


/*
          4

      7       2

    9   6   3   1
*/

public:
    void Traverse(TreeNode* current) {
        if (current == nullptr) return;
        TreeNode* temp = current->left;
        current->left = current->right;
        current->right = temp;

        Traverse(current->left);
        Traverse(current->right);
    }

    TreeNode* invertTree(TreeNode* root) {
        Traverse(root);
        return root;
    }
};