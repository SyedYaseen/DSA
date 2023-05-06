// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics;
using System.Xml;
using DSA.ArrayDSA;
using DSA.AVLTreeDS;
using DSA.DictionaryDSA;
using DSA.LinkedListDSA;
using DSA.QueueDSA;
using DSA.StackClassDSA;
using DSA.TreeDS;

// var dict = new DictionaryClass();
// dict.Put(5, "Yaseen");
// dict.Put(5, "Angry");
// dict.Put(1, "Syed");
// dict.Put(10, "POtato");
// Console.WriteLine(dict.Get(5));

// var repeatChar = new RepeatedCharacter();
// char[] arr = new[] { 'a', 'b', 'c', 'a', 'b', 'a', 'a' };
// Console.WriteLine(repeatChar.FindMostRepeatedElement(arr));

// int[] arrInt = new[] {1, 7, 5, 9, 2, 12, 3};
// Console.WriteLine(repeatChar.CountPairsWithDiff(arrInt, 2));
// var Tree = new TreeClass();
// var Tree1 =  new TreeClass();
// var Tree2 =  new TreeClass();

// var list1 = new List<int> { -5, 20, 10, 30, 6, 14, 24, 3, 8, 26};
// var list2 = new List<int> { -5, 20, 10, 30, 6, 14, 24, 3, 8, 26};
// var list = new List<int> { 3, 2, 5 };

// list.ForEach(item => Tree1.Insert(item));
// list2.ForEach(item => Tree2.Insert(item));
// Tree = Tree1;

//Console.WriteLine(Tree.Find(5));
// List<int> result = Tree.DepthPreOrderTraversal();
// result.ForEach(x => Console.WriteLine(x));
//Tree.DepthInOrderTraversal();
//Tree.DepthPostOrderTraversal();
//Console.WriteLine(Tree.Height());
// Console.WriteLine(Tree.Min());
// Console.WriteLine(Tree1.Equality(Tree2));

// Tree1.SwapNodes();
// Console.WriteLine(Tree1.isBinarySearchTree());


// var result = Tree.NodeAtKLevel(2);
// result.ForEach(x => Console.WriteLine(x));


// var list = new List<int> {10, 5, 15, 6, 1, 8, 12, 18, 17 };

var list = new List<int> { 30, 20, 10 };
var avl = new AVLTree();
list.ForEach(x => avl.Insert(x));
// avl.Insert(200);
// Console.Write("This");