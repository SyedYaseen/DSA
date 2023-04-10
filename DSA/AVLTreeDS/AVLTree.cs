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

        return current;
    }
}

public class Node
{
    public int Value;
    public Node? LeftChild;
    public Node? RightChild;

    public Node(int val)
    {
        Value = val;
    }

    public override string ToString()
    {
        return "Node=" + Value;
    }
}
