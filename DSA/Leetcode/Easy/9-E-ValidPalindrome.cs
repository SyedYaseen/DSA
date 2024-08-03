namespace DSA.Leetcode.Easy
{
    public class ValidPalindrome
    {
        public bool Soln(string s)
        {
            s = s.ToLower();
            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (!Char.IsLetter(s[i]) && !Char.IsNumber(s[i]))
                {
                    i++;
                    continue;
                }
                if (!Char.IsLetter(s[j]) && !Char.IsNumber(s[j]))
                {
                    j--;
                    continue;
                }

                if (s[i] != s[j]) return false;
                if (s[i] == s[j]) { i++; j--; }
            }


            return true;

        }
    }
}

//var cl = new ValidPalindrome();
//var y = cl.Soln("ab2a");
//var x = cl.Soln("0P");
//var a = cl.Soln("A man, a plan, a canal: Panama");
//var b = cl.Soln("race a car");
//var c = cl.Soln(" ");
//var d = " ";
