namespace DSA.QueueDSA;

public class ArrayQueue
{
    public int _front = 0;
    public int _back = -1;
    public int _size = 0;
    private int[] ArrayQ;
    
    public ArrayQueue(int size)
    {
        _size = size;
        ArrayQ = new int[_size];
    }
    
    public int DeQueue()
    {
        if (_front < _back + 1) return ArrayQ[_front++];
        else throw new NullReferenceException("Empty Queue during Dequeue");
    }

    public int Peek()
    {
        if (_front <= _back) return ArrayQ[_front];
        else throw new NullReferenceException("Empty Queue during Peek");
    }
    
    public void EnQueue(int value)
    {
        if(_back < _size - 1) ArrayQ[++_back] = value;
        else
        {
            NewArrayQueue();
            EnQueue(value);
        }
    }

    // public bool IsFull()
    // {
    //     return _back == _size - 1 ? true : false;
    // }
    //
    // public bool IsEmpty()
    // {
    //     return _front > _back ? true : false;
    // }
    
    private void NewArrayQueue()
    {
        _size = _size * 2;
        var newArrQ = new int[_size];
        for (int i = 0; i <= _back; i++)
        {
            newArrQ[i] = ArrayQ[i];
        }
        ArrayQ = newArrQ;
    }
}