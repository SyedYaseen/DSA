// See https://aka.ms/new-console-template for more information

using DSA.Leetcode;
using DSA.Leetcode.Medium;

var cl = new EncodeAndDecodeStrings();

var inputs = new List<List<string>>()
{
    new List<string>() {"neet","code","love","you"},
    new List<string>() { "we", "say", ":", "yes" }

};

foreach (var i in inputs)
{
    cl.Soln(i);
}
