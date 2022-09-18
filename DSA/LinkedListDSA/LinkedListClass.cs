using System.Xml;

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

        public int GetValue()
        {
            return _value;
        }

    }
    
    public Node? First;
    public Node? Last;
    private int size;

    public void AddLast(int value)
    {
        var newNode = new Node(value);
        if (First == null)
        {
            First = Last = newNode;
            size++;
        }
        else
        {
            Last!._next = newNode;
            Last = newNode;
            size++;
        }
    }

    public void AddFirst(int value)
    {
        var newNode = new Node(value);
        if (First == null)
        {
            First = Last = newNode;
            size++;
        }
        else
        {
            newNode._next = First;
            First = newNode;
            size++;
        }
    }

    public int IndexOf(int value)
    {
        var node = First;
        int count = 0;
        while (node != null)
        {
            if (node.GetValue() == value) return count;
            else
            {
                if (node._next != null)
                {
                    node = node._next;
                    count++;
                }
            }
        }

        return -1;
    }

    public bool Contains(int value)
    {
        if (IndexOf(value) == -1) return false;
        else return true;
    }

    public int RemoveFirst()
    {
        if (First == null) return -1;
        
        else if (First == Last)
        {
            First = Last = null;
            size--;
            return 1;
        }
        else
        {
            var second = First._next;
            First._next = null;
            First = second;
            size--;
            return 1;
        }
    }

    public int RemoveLast()
    {
        if (First == null) return -1;
        
        else if (First == Last)
        {
            First = Last = null;
            size--;
            return 1;
        }

        else
        {
            var node = First;
            Node prevNode = null!;
            
            while (node._next != null)
            {
                prevNode = node;
                node = node._next;
            }

            prevNode._next = null;
            Last = prevNode;
            size--;
            return 1;
        }
    }
    
    public int[] ToArray()
    {
        if (First == null) return new int[0];
        
        var arr = new int[GetSize()];
        var node = First;
        int count = 0;
        while (node != null)
        {
            arr[count++] = node.GetValue();
            node = node._next;
        }

        return arr;
    }

    public void Reverse()
    {
        Node previous = First;
        Node current = previous._next;

        Last = First;
        Last._next = null;
        
        while (current != null)
        {
            var next = current._next;
            
            current._next = previous;
            previous = current;
            current = next;
        }
        First = previous;
    }

    public int GetKthNode(int k)
    {
        if (k <= 0) throw new ArgumentOutOfRangeException();
        if (First == null) throw new NullReferenceException();

        Node result = First;
        Node current = First;
        int distance = 0;
        int size = 0;

        while (current._next!= null)
        {
            current = current._next;
            size++;
            if (distance < k) distance++;
            if (distance == k) result = result._next;
        }
        
        if (k > size) throw new ArgumentOutOfRangeException();
        return result.GetValue();
    }

    public void PrintMiddle()
    {
        if (First == Last) Console.WriteLine(First.GetValue());
        if (First == null) throw new NullReferenceException();

        //Mosh soln
        Node a = First;
        Node b = First;

        while (b!=Last && b._next!= Last)
        {
            b = b._next._next;
            a = a._next;
        }
        
        Console.WriteLine(
            b == Last ? 
                a.GetValue() : 
                (a.GetValue(), a._next.GetValue()));


        //My solution

        // Node middle = First;
        // Node current = First;
        // int count = 0;
        //
        // while (current._next!= null)
        // {
        //     current = current._next;
        //     count++;
        //     if (count % 2 == 0) middle = middle._next;
        // }
        //
        // Console.WriteLine(
        //     count % 2 == 0 ? 
        //         middle.GetValue() : 
        //         (middle.GetValue(), middle._next.GetValue()));
    }

    public bool HasLoop()
    {
        var slow = First;
        var fast = First;

        while (fast!= Last && fast._next!= Last)
        {
            fast = fast._next._next;
            slow = slow._next;

            if (fast == slow) return true;
        }

        return false;
    }
    
    public int GetSize()
    {
        return size;
    }
}