using System;
using System.Collections.Generic;
using System.Linq;

public class GroupAnagrams
{
    public IList<IList<string>> Soln(string[] strs) {
        var result = new List<IList<string>>();
        var mp = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            
              
            var chars = strs[i].ToArray();
            Array.Sort(chars);
            var sortedStr = string.Join("", chars);

            if(sortedStr != null && mp.ContainsKey(sortedStr))
                mp[sortedStr].Add(strs[i]);
            else mp.Add(sortedStr, new List<string>(){ strs[i] });
        }
        foreach (var item in mp.Values)
        {
            result.Add(item);
        }


        return result;
    }
    
    // This code only beats 5%

    public IList<IList<string>> Soln1(string[] strs)
	{
        var s = strs.ToList();
        var result= new List<IList<string>>();

		while (s.Count != 0)
		{
            var last = s[^1];
            s.RemoveAt(s.Count - 1);
            var innerList = new List<string>() { last };
            
            for (int i = 0; i < s.Count; i++)
            {
                if (IsAnagram(s[i], last))
                {
                    innerList.Add(s[i]);
                    s.RemoveAt(i);
                    i--;
                }
            }

            result.Add(innerList);
        }

        return result;
	}

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var d = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (d.ContainsKey(s[i])) d[s[i]] += 1;
            else d[s[i]] = 1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!d.ContainsKey(t[i])) return false;
            else
            {
                d[t[i]] -= 1;

                if (d[t[i]] == 0) d.Remove(t[i]);
            }
        }

        if (d.Count != 0) return false;

        return true;

    }
}

//var c = new GroupAnagrams();

//Console.WriteLine(c.Soln(new string[]
//{
//    "eat", "tea", "tan", "ate", "nat", "bat"
//}));

//Console.WriteLine(c.Soln(new string[]
//{
//    ""
//}));

//Console.WriteLine(c.Soln(new string[]
//{
//    "a"
//}));
