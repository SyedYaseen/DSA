

namespace DSA.TreeDS;

public class TreeClass
{
    private Node? _root;
    private Node? _current;
    private List<int> treeTraversalResult = new();
    
    private int _left;
    private int _right;

    public void Insert(int nodeValue)
    {
        if (_root == null)
        {
            _root = new Node(nodeValue);
            return;
        }
        
        _current = _root;
        while (_current != null)
        {
            if (nodeValue < _current.Value)
            {
                if (_current.LeftChild == null)
                {
                    _current.LeftChild = new Node(nodeValue);
                    return;
                } 
                _current = _current.LeftChild;
            }

            if (nodeValue > _current.Value)
            {
                if (_current.RightChild == null)
                {
                    _current.RightChild = new Node(nodeValue);
                    return;
                } 
                _current = _current.RightChild;
            }

        }
    }

    public bool Find(int value)
    {
        if(_root != null)
        {
            _current = _root;

            while(_current != null)
            {
                if(_current.Value == value) return true;

                if(value < _current.Value) _current = _current.LeftChild;
   
                if(value > _current.Value) _current = _current.RightChild;
            }
        }


        return false;
    }

    public List<int> DepthPreOrderTraversal()
    {
        treeTraversalResult = new List<int>();
        DepthPreOrder(_root!);
        return treeTraversalResult;
    }

    private void DepthPreOrder(Node node)
    {
        if (node != null)
        {
            treeTraversalResult.Add(node.Value);
            if (node?.LeftChild != null) DepthPreOrder(node.LeftChild);
            if (node?.RightChild != null) DepthPreOrder(node.RightChild);
        }
    }

    public List<int> DepthInOrderTraversal()
    {
        treeTraversalResult= new List<int>();
        DepthInOrder(_root!);
        return treeTraversalResult;
    }

    private void DepthInOrder(Node node)
    {
        if (node != null)
        {
            if(node.LeftChild != null) DepthInOrder(node.LeftChild);
            treeTraversalResult.Add(node.Value);
            if (node.RightChild != null) DepthInOrder(node.RightChild);
        }
    }

    public List<int> DepthPostOrderTraversal()
    {
        treeTraversalResult = new List<int>();
        DepthPostOrder(_root!);
        return treeTraversalResult;
    }

    private void DepthPostOrder(Node node)
    {
        if (node != null)
        {
            if (node.LeftChild != null) DepthPostOrder(node.LeftChild);
            if (node.RightChild != null) DepthPostOrder(node.RightChild);
            treeTraversalResult.Add(node.Value);
        }
    }


    public int Height()
    {
        if (_root == null) return -1;
       return Height(_root);
    }

    private int Height(Node node)
    {
        if ((node.LeftChild == null && node.RightChild == null) ) return 0;

        return 1 + Math.Max(
            Height(node?.LeftChild!), 
            Height(node?.RightChild!)
            );
    }

    public int Min()
    {

        return Min(_root);
    }

    private int Min(Node node)
    {
        if (node.LeftChild == null) return node.Value;

        var left = Min(node?.LeftChild);
        

        return Math.Min(node.Value, left);
    }

}






    internal class Node
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


