namespace DSA.Leetcode;

public class GroupAnagramsSoln {
    public IList<IList<string>> GroupAnagrams(string[] strs)
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