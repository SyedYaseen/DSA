// See https://aka.ms/new-console-template for more information

using DSA.Leetcode;
using DSA.Leetcode.Easy;
using DSA.Leetcode.Medium;
using DSA.SortAlgo;
using System.Collections.Generic;
using System.Numerics;

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

//var cl = new CountSort();

//var inputs = new List<int[]>()
//{
//    new int[] {5,3,8,5,1,2,8}


//};

//foreach (var i in inputs)
//{
//    cl.Srt(i);
//}

//foreach (var i in inputs)
//{
//    cl.Soln(i);
//}

//var cl = new RotateArray();

//cl.Soln([1, 2, 3, 4, 5, 6, 7], 3);
//cl.Soln([-1, -100, 3, 99], 2);



var cl = new ThreeSum();

var a= cl.Soln([-1, 0, 1, 2, -1, -4]); // [-1,0,1] and [-1,-1,2]
var b = cl.Soln([0, 1, 1]); // []
var c = cl.Soln([0, 0, 0]); // 0
var d = cl.Soln([1, 2, -2, -1]); // []
var e = cl.Soln([-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4]);
// [[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]


