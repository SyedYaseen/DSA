#include "imports.h"
#include "Tree.h"
using namespace std;
//#include "./Medium/CountAndSay-38-M.h"
#include "./Medium/RottingOranges-994-M.h"
int main() {
	Solution s;

	//vector<vector<int>> t1 = { { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 }, { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 } };
	vector<vector<int>> t1 = { {2, 1, 1},{1, 1, 0}, {0, 1, 1} };
	s.orangesRotting(t1);
	// 
	//s.countAndSay(6);
	
	//s.decodeAtIndex("leet2code3", 10);
	 //s.decodeAtIndex("a23bc23", 42);
	 /*s.decodeAtIndex("a2b3c4d5e6f7g8h9", 10);*/
	// s.decodeAtIndex("ha22", 5);
	 // s.decodeAtIndex("y959q969u3hb22odq595", 222280369);
	 // s.decodeAtIndex("gl2sld3935dz5wx5r64x", 1392818);
	 //s.decodeAtIndex("a2345678999999999999999", 1);
	 //s.decodeAtIndex("a23b23", 41);
	//TreeNode* t1 = new TreeNode(4, 
	//	new TreeNode(2, 
	//		new TreeNode(1), 
	//		new TreeNode(3)), 
	//	new  TreeNode(7, 
	//		new TreeNode(6), 
	//		new TreeNode(9)));

	//TreeNode* t2 = new TreeNode(3,
	//	new TreeNode(9),
	//	new TreeNode(20, 
	//		new TreeNode(15), new TreeNode(7)));

	//s.maxDepth(t1);
	//int a = s.isBalanced(t2);
	//string x = s.decodeString("100[leetcode]");
    //int a = s.bestClosingTime("YYNY");
	//int a = s.bestClosingTime("NYNNNYYN"); // ans 0
	
	//string a = s.decodeString("zxy3[a]2[bc]");
	//string b = s.decodeString("zxy3[a2[c]]");
	
	return 0;
}