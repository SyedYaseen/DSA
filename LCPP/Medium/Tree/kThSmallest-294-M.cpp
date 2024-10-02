#include "../../imports.h"

class Solution
{
public:
    int res;
    void traverse(TreeNode *root, int &k)
    {

        if (root->left)
            traverse(root->left, k);

        if (!root->left)
            k -= 1;

        if (k == 0)
        {
            res = root->val;
            return;
        }

        if (root->right)
            traverse(root->right, k);

        // if (!root->left && !root->right) {k--; return;}
    }

    int kthSmallest(TreeNode *root, int k)
    {
        traverse(root, k);
        return res;
    }
};

int main()
{
    Solution s;
    TreeNode *root = nullptr;

    root = insertIntoBST(root, 3);
    root = insertIntoBST(root, 1);
    root = insertIntoBST(root, 4);
    root = insertIntoBST(root, 2);
    s.kthSmallest(root, 1);
}