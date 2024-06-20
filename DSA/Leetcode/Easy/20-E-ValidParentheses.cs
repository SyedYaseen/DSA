
namespace DSA.Leetcode.Easy
{
    public class ValidParentheses
    {
        public bool Soln(string s)
        {
            if (s.Length % 2 != 0) return false;

            var st = new Stack<char>();
            var brackets = new Dictionary<char, char>(3);
            brackets.Add(')', '(');
            brackets.Add(']', '[');
            brackets.Add('}', '{');

            for (int i = 0; i < s.Length; i++)
            {
                if (!brackets.ContainsKey(s[i])) st.Push(s[i]);

                if (brackets.ContainsKey(s[i])) {
                    if (st.Count == 0) return false;

                    if(st.Pop() != brackets[s[i]]) 
                        return false;

                }
            }
            return st.Count == 0 ? true : false;
        }

        public bool TopSoln(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else if (stack.Count == 0 || c != stack.Pop())
                {
                    return false;
                }
            }
            return stack.Count() == 0;
        }
    }

    
}
