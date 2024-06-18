// See https://aka.ms/new-console-template for more information

using DSA.Leetcode;
using DSA.Leetcode.Easy;
using DSA.Leetcode.Medium;
using DSA.SortAlgo;
using System.Collections.Generic;

//var cl = new EncodeAndDecodeStrings();

//var inputs = new List<List<string>>()
//{
//    new List<string>() {"neet","code","love","you"},
//    new List<string>() { "we", "say", ":", "yes" }

//};

//foreach (var i in inputs)
//{
//    cl.Soln(i);
//}

var cl = new CountSort();

var inputs = new List<int[]>()
{
    new int[] {5,3,8,5,1,2,8}


};

foreach (var i in inputs)
{
    cl.Srt(i);
}

//foreach (var i in inputs)
//{
//    cl.Soln(i);
//}

//var cl = new RotateArray();

//cl.Soln([1, 2, 3, 4, 5, 6, 7], 3);
//cl.Soln([-1, -100, 3, 99] , 2);
