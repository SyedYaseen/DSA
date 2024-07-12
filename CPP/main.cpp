#include <iostream>
#include <vector>
#include "Tree.h"
using namespace std;
#include "BalancedBinaryTree-110-E.h"
int main() {
	Solution s;

	TreeNode* t1 = new TreeNode(4, 
		new TreeNode(2, 
			new TreeNode(1), 
			new TreeNode(3)), 
		new  TreeNode(7, 
			new TreeNode(6), 
			new TreeNode(9)));

	TreeNode* t2 = new TreeNode(3,
		new TreeNode(9),
		new TreeNode(20, 
			new TreeNode(15), new TreeNode(7)));

	//s.maxDepth(t1);
	int a = s.isBalanced(t2);
	
	return 0;
}