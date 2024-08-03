namespace DSA.QueueDSA;

public class PriorityQueueClass
{
    public int[] Q;
    private int _count = -1;

    public PriorityQueueClass()
    {
        Q = new int[10];
    }

    public void EnQueue(int value)
    {
        if (_count == -1) Q[++_count] = value;

        else
        {
            for (int i = _count; i >= 0; i--)
            {
                if (Q[i] > value) Q[i + 1] = Q[i];
                else
                {
                    Q[i + 1] = value;
                    _count++;
                    break;
                }
            }
        }
    }

    public int DeQueue()
    {
        return 99;
    }
}