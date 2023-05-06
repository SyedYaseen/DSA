using System.Runtime.CompilerServices;

namespace DSA.AVLTreeDS;

public class AVLTree
{
    private Node _root;
    
    public void Insert(int nodeValue)
    {
        _root = Insert(nodeValue, _root);
    }

    private Node Insert(int value, Node current)
    {
        if (current == null) return new Node(value);
        
        if (value < current.Value) 
            current.LeftChild = Insert(value, current.LeftChild);

        else 
            current.RightChild = Insert(value, current.RightChild);

        current.Height = 1 + Math.Max(
                                Height(current.LeftChild), 
                                Height(current.RightChild));

        
        
        if (BalanceFactor(current) > 1)
        {
            BalanceFactor(current.LeftChild);
            Console.WriteLine("Left heavy: " + current.Value);
        }   

        if (BalanceFactor(current) < -1)
        {
            if (BalanceFactor(current.RightChild) > 1)
            {
                Console.WriteLine("Right rotate" + current.RightChild.Value);
            }
            
            Console.WriteLine("Right heavy: " + current.Value);
        }
        
        return current;
    }

    public int BalanceFactor(Node node)
    {
        return Height(node.LeftChild) - Height(node.RightChild);
    }

    public int Height()
    {
        return Height(_root);
    }

    private int Height(Node node)
    {
        return node == null ? -1 : node.Height;
    }
}

public class Node
{
    public int Value;
    public Node? LeftChild;
    public Node? RightChild;
    public int Height;

    public Node(int val)
    {
        Value = val;
    }

    public override string ToString()
    {
        return "Node=" + Value;
    }
}
