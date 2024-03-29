﻿namespace DSA.Leetcode;

public class GroupAnagramsSoln {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> mem = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {

            string current = SortString(strs[i]);
            if (mem.ContainsKey(current))
                mem[current].Add(strs[i]);
            else
                mem.Add(current, new List<string>{strs[i]});
        }
        
        return new List<IList<string>>(mem.Values);
    }
    
    static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }


    public IList<IList<string>> GroupAnagrams2(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        List<string> strss = strs.ToList();
        
        int i = 0;
        while (strss.Count > 0 && i < strss.Count)
        {
            var item = strss[i];
            List<string> current = new List<string>();
            current.Add(item);
            strss.Remove(item);
            
            Dictionary<char, int> mem = new Dictionary<char, int>();
            foreach (var ch in item)
            {
                if (!mem.ContainsKey(ch))
                    mem[ch] = 1;
                else
                    mem[ch] += 1;
            }
            

            int j = 0;
            while (strss.Count > 0 && j < strss.Count)
            {
                if (item.Length == strss[j].Length && isAnagram(new Dictionary<char, int>(mem), strss[j]))
                {
                    current.Add(strss[j]);
                    strss.RemoveAt(j);
                    j = 0;
                }
                else
                    j++;
            }
            result.Add(current);
        }
        return result;
    }

    public bool isAnagram(Dictionary<char, int> mem, string t)
    {
        foreach (var i in t)
        {
            if (!mem.ContainsKey(i) || mem[i] == 0)
                return false;
            
            mem[i] -= 1;
        }
        return true;
    }
}