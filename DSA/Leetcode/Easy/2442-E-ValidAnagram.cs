public class ValidAnagram
{

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
    // This is a palindrome checker
    //public bool IsAnagram(string s, string t)
    //{
    //    if (s.Length != t.Length) return false;

    //    int i = 0;
    //    int j = t.Length -1;

    //    while (i < j)
    //    {
    //        if (s[i] != t[j]) return false;
    //        i++;
    //        j--;
    //    }

    //    return true;
    //}
}
//var c = new ValidAnagram();
//Console.WriteLine(c.IsAnagram("anagram", "nagaram"));
//Console.WriteLine(c.IsAnagram("mom", "mom"));
//Console.WriteLine(c.IsAnagram("ten", "nut"));
