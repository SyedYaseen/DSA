namespace DSA.QueueDSA;

public static class ReverseUntilKthElement
{
    public static Queue<int> ReverseUntilK(int k, Queue<int> queue)
    {
        Queue<int> result = new Queue<int>();
        Stack<int> tempStack = new Stack<int>();
        int count = 0;

        while (count != k)
        {
            tempStack.Push(queue.Dequeue());
            count++;
        }

        while (tempStack.Any())
        {
            result.Enqueue(tempStack.Pop());
        }

        while (queue.Any())
        {
            result.Enqueue(queue.Dequeue());
        }

        return result;
    }
}