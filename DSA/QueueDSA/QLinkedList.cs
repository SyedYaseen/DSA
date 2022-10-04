using DSA.LinkedListDSA;

namespace DSA.QueueDSA;

public class QLinkedList
{
    private LinkedListClass Q;

    public QLinkedList()
    {
        Q = new LinkedListClass();
    }

    public void Enqueue(int val)
    {
        if (Q.First == null)
        {
            Q.AddFirst(val);
            Q.Last = Q.First;
        }
        
        else Q.AddLast(val);
    }

    public int Dequeue()
    {
        if (Q.First != null) return Q.RemoveFirst();
        else throw new NullReferenceException();
    }
    
}