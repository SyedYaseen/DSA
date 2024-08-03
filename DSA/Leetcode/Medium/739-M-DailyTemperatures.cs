namespace DSA.Leetcode.Medium
{
    public class DailyTemperatures
    {
        public int[] Soln(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            if (temperatures.Length == 0) return [];
            if (temperatures.Length == 1) return [0];

            var st = new Stack<int>();

            st.Push(0);
            for (int i = 1; i < temperatures.Length; i++)
            {
                // If current temp > top of stack
                // Add the current index - index of the popped element
                while (st.Count != 0 && temperatures[i] > temperatures[st.Peek()])
                {
                    var index = st.Pop();
                    result[index] = i - index;
                }

                if (st.Count == 0 || temperatures[i] <= temperatures[st.Peek()])
                {
                    st.Push(i);
                }
            }
            result[temperatures.Length - 1] = 0;
            return result;
        }

        // Works but bad perfomance
        public int[] Soln3(int[] temperatures)
        {
            var result = new int[temperatures.Length];
            if (temperatures.Length == 0) return [];
            if (temperatures.Length == 1) return [0];

            var st = new Stack<Dictionary<int, int>>();

            st.Push(new Dictionary<int, int>() { { temperatures[0], 0 } });
            for (int i = 1; i < temperatures.Length; i++)
            {
                // If current temp > top of stack
                // Add the current index - index of the popped element
                while (st.Count != 0 && temperatures[i] > st.Peek().First().Key)
                {
                    var top = st.Pop().First();
                    var key = top.Key;
                    var index = top.Value;
                    result[index] = i - index;
                }

                if (st.Count == 0 || temperatures[i] <= st.Peek().First().Key)
                {
                    st.Push(new Dictionary<int, int>() { { temperatures[i], i } });
                }

            }
            result[temperatures.Length - 1] = 0;
            return result;
        }


        // Fails for an absurd testcase
        public int[] Soln2(int[] temperatures)
        {
            if (temperatures.Length <= 1) return [0];
            int i = 0;
            int j = i + 1;

            while (i < temperatures.Length - 1)
            {
                if (j == temperatures.Length)
                {
                    temperatures[i] = 0;
                    i++;
                    j = i + 1;
                }
                else if (temperatures[j] > temperatures[i])
                {
                    temperatures[i] = j - i;
                    i++;
                    j = i + 1;
                }
                else j++;
            }
            temperatures[temperatures.Length - 1] = 0;
            return temperatures;
        }
    }
}

//var cl = new DailyTemperatures();

//var a = cl.Soln([73, 74, 75, 71, 69, 72, 76, 73]);
////[1,1,4,2,1,1,0,0]
//var b = cl.Soln([30, 40, 50, 60]);
////[1, 1, 1, 0]
//var c = cl.Soln([30, 60, 90]);
//// [1,1,0]
//var d = cl.Soln([99, 99, 99]);

//var e = cl.Soln([89, 62, 70, 58, 47, 47, 46, 76, 100, 70]);
//// [8,1,5,4,3,2,1,1,0,0]