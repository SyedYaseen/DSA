namespace DSA.Leetcode;

public class ValidAnagram {
    // public bool IsAnagram(string s, string t)
    // {
    //     if (s.Length != t.Length)
    //         return false;
    //     Dictionary<char, int> mem = new Dictionary<char, int>();
    //     foreach (var i in s)
    //     {
    //         if (!mem.ContainsKey(i))
    //         {
    //             mem[i] = 1;
    //         }
    //         else
    //         {
    //             mem[i] += 1;
    //         }
    //     }
    //
    //     foreach (var i in t)
    //     {
    //         if (!mem.ContainsKey(i) || mem[i] == 0)
    //         {
    //             return false;
    //         }
    //
    //         mem[i] -= 1;
    //     }
    //     return true;
    // }
    
    
    public bool isAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> mem = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (mem.ContainsKey(s[i]))
                mem[s[i]]++;
            else
                mem[s[i]] = 1;
            
            if (mem.ContainsKey(t[i]))
                mem[t[i]]--;
            else
                mem[t[i]] = -1;
        }
        
        foreach (var i in mem.Values)
        {
            if (i != 0)
                return false;
        }

        return true;
    }
}