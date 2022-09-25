namespace DSA.QueueDSA;

public class ArrQCircularArray
{
    private int _front;
    private int _back;
    private int[] ArrayQ;
    public int Count;
    
    public ArrQCircularArray(int size)
    {
        ArrayQ = new int[size];
    }
    
    public void EnQueue(int value)
    {
        if (Count < ArrayQ.Length)
        {
            ArrayQ[_back] = value;
            _back = (_back + 1) % ArrayQ.Length;
            Count++;
        }
        else throw new StackOverflowException("No space");
    }
    
    public int DeQueue()
    {
        if (Count > 0)
        {
            var item = ArrayQ[_front];
            ArrayQ[_front] = 0;
            Count--;
            _front = (_front + 1) % ArrayQ.Length;

            return item;
        }
        
        else throw new NullReferenceException("Q is empty");
    }

    public int Peek()
    {
        if (_front <= _back) return ArrayQ[_front];
        else throw new NullReferenceException("Empty Queue during Peek");
    }
}