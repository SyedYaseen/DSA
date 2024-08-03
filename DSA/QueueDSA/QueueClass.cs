namespace DSA.QueueDSA;

public class QueueClass
{
    public static Queue<int> ReverseQ(Queue<int> queue)
    {
        var result = new Queue<int>();
        var tempStack = new Stack<int>();

        while (queue.Any()) tempStack.Push(queue.Dequeue());
        while (tempStack.Any()) result.Enqueue(tempStack.Pop());

        return result;
    }

}