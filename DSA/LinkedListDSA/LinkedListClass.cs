namespace DSA.LinkedListDSA;

public class LinkedListClass
{
    public class Node
    {
        private int _value;
        public Node? _next;

        public Node(int value)
        {
            _value = value;
        }
    }
    
    public Node? First;
    public Node? Last;

    public void AddLast(int value)
    {
        var newNode = new Node(value);
        if (First == null)
        {
            First = Last = newNode;
        }
        else
        {
            Last!._next = newNode;
            Last = newNode;
        }
    }

    public void AddFirst(int value)
    {
        var newNode = new Node(value);
        if (First == null)
        {
            First = Last = newNode;
        }
        else
        {
            newNode._next = First;
            First = newNode;
        }
    }
}