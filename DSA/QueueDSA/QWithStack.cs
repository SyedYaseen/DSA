using System.Collections;

namespace DSA.QueueDSA;

public class QWithStack
{
    private Stack _forward;
    private Stack _backward = new Stack();

    public QWithStack()
    {
        _forward = new Stack();
    }

    public void EnQueue(int value)
    {
        _forward.Push(value);
    }

    public int DeQueue()
    {
        if (_backward.Count == 0 && _forward.Count > 0)
        {
            var count = _forward.Count;
            for (int i = 0; i < count; i++)
            {
                _backward.Push(_forward.Pop());
            }
        }

        return (int)(_backward.Pop() ?? throw new InvalidOperationException());
    }
}