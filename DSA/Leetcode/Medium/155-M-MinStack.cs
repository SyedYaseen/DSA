namespace DSA.Leetcode.Medium
{
    public class MinStack
    {
        List<int[]> stack;
        int count = 0;
        public MinStack()
        {
            stack = new List<int[]>();
        }

        public void Push(int val)
        {
            if (count == 0) stack.Add([val, Math.Min(val, val)]);
            else stack.Add([val, Math.Min(val, GetMin())]);
            count++;
        }

        public void Pop()
        {

            stack.RemoveAt(count - 1);
            count--;

        }

        public int Top()
        {

            return stack.Last()[0];

        }

        public int GetMin()
        {
            return stack.Last()[1];
        }
    }
}
