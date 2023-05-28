using System.Runtime.CompilerServices;
using DSA.LinkedListDSA;

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

        current = Balance(current);
        
        
        return current;
        
    }

    
    private Node Balance(Node current)
    {
        //         50
        //     30
        // 20
        if (BalanceFactor(current) > 1)
        {
            Console.WriteLine(current.Value + " is left heavy");
            var leftChildBalanceFactor = BalanceFactor(current.LeftChild);
            
            if (leftChildBalanceFactor < 0)
            {
                
                Console.WriteLine("Left rotate " + current.LeftChild.Value);
                current.RightChild = LeftRotation(current.LeftChild);
            }
            Console.WriteLine("Right rotate " + current.Value);
            return RightRotation(current);
        }
        
        if (BalanceFactor(current) < -1)
        {
            Console.WriteLine(current.Value + " is right heavy");
            var rightChildBalanceFactor = BalanceFactor(current.RightChild);
            
            if ( rightChildBalanceFactor > 0)
            {
                Console.WriteLine("Right rotate " + current.RightChild.Value);
                current.LeftChild = RightRotation(current.RightChild);
            }
            
            Console.WriteLine("Left rotate " + current.Value);
            return LeftRotation(current);
        }

        return current;
    }


    private Node LeftRotation(Node root)
    {
        var newRoot = root.RightChild;
        root.RightChild = newRoot.LeftChild;
        newRoot.LeftChild = root;
        
        SetHeight(root);
        SetHeight(newRoot);

        return newRoot;
    }

    private Node RightRotation(Node root)
    {
        var newRoot = root.LeftChild;
        root.LeftChild = newRoot.RightChild;
        newRoot.RightChild = root;
        
        SetHeight(root);
        SetHeight(newRoot);

        return newRoot;
    }

    private void SetHeight(Node node)
    {
        node.Height = 
            Math.Max( Height(node.LeftChild), Height(node.RightChild)) + 1;
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
