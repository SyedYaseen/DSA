using DSA.Leetcode.Medium;

namespace DSA.Leetcode.Medium
{
    internal class ReversePolishNotation
    {

        public int Soln(string[] tokens)
        {
            var st = new Stack<string>();
            
            for (int i = 0; i < tokens.Length; i++)
            {
                string c = tokens[i];

                if (c == "+" || c == "-" || c == "*" || c == "/")
                {
                    int num2 = int.Parse(st.Pop());
                    int num1 = int.Parse(st.Pop());
                    int temp = 0;
                    if (c == "+") {
                        temp = num1 + num2;
                    }

                    else if (c == "*")
                    {
                        temp = num1 * num2;
                    }

                    else if (c == "/")
                    {
                        temp = num1 / num2;
                    }

                    else if (c == "-")
                    {
                        temp = num1 - num2;
                    }

                    st.Push(temp.ToString());
                }

                else st.Push(c);

            }

            return int.Parse(st.Pop());
        }
    }
}

//var cl = new ReversePolishNotation();

//var a = cl.Soln(["2", "1", "+", "3", "*"]);
//var b = cl.Soln(["4", "13", "5", "/", "+"]);
//var c = cl.Soln(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]);
//var f = 'a';