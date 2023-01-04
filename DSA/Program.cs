// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Xml;
using DSA.ArrayDSA;
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

var Tree =  new TreeClass();
//var list = new List<int> {10, 5, 15, 6, 1, 8, 12, 18, 17 };
var list = new List<int> { 20, 10, 30, 6, 14, 24, 3, 8, 26 };

foreach (var val in list)
{
    Tree.Insert(val);
}
//Console.WriteLine(Tree.Find(5));






