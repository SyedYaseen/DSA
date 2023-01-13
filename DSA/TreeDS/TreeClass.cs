using System.Security.Cryptography.X509Certificates;

namespace DSA.TreeDS;

public class TreeClass
{
    private Node? _root;
    private Node? _current;
    private List<int> treeTraversalResult = new();

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

            if(node.LeftChild != null)
            {
                DepthInOrder(node.LeftChild);
                if(node.LeftChild == null && node.RightChild == null) 
                    treeTraversalResult.Add(node.Value);

                if(node.RightChild != null)
                    DepthInOrder(node.RightChild);
            }





            //if (node?.LeftChild != null)
            //{
            //    DepthInOrder(node.LeftChild);

            //}
            //treeTraversalResult.Add(node.Value);





            //if (node?.RightChild != null)
            //{
            //    DepthInOrder(node.RightChild);
            //    treeTraversalResult.Add(node.Value);
            //}
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


}