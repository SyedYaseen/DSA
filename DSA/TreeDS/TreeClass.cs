using System.Security.Cryptography.X509Certificates;

namespace DSA.TreeDS;

public class TreeClass
{
    private Node? _root;
    private Node? _current;

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

    public List<int> DepthPreOrder()
    {
        List<int> result = new List<int>();
        _current = _root;
        
        while(_current != null)
        {
            var rootValue = GetValue(_current);

            result.Add(_current.Value);
            if (_current.LeftChild != null)
            {
                GetValue(_current.LeftChild);
            }

        }


        return result;
    }

    public int GetValue(Node root)
    {
        var rootValue = root.Value;
        if(root.LeftChild != null)
        {
            GetValue(root.LeftChild);


        }

        if(root.RightChild != null)
        {
            GetValue(root.RightChild);
        }


        return root.Value;
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