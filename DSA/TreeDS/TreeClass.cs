

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
        if (_root != null)
        {
            _current = _root;

            while (_current != null)
            {
                if (_current.Value == value) return true;

                if (value < _current.Value) _current = _current.LeftChild;

                if (value > _current.Value) _current = _current.RightChild;
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
        treeTraversalResult = new List<int>();
        DepthInOrder(_root!);
        return treeTraversalResult;
    }

    private void DepthInOrder(Node node)
    {
        if (node != null)
        {
            if (node.LeftChild != null) DepthInOrder(node.LeftChild);
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
        if (node == null) return;

        DepthPostOrder(node.LeftChild);
        DepthPostOrder(node.RightChild);
        treeTraversalResult.Add(node.Value);

    }

    public int Height()
    {
        if (_root == null) return -1;
        return Height(_root);
    }

    private int Height(Node node)
    {
        if ((node.LeftChild == null && node.RightChild == null)) return 0;

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

    public bool Equality(TreeClass other)
    {
        return Equal(_root, other._root);
    }


    public bool Equal(Node node1, Node node2)
    {

        if (node1 == null && node2 == null) return true;

        if (node1 != null && node2 != null) return
            node1.Value == node2.Value &&
            Equal(node1.LeftChild, node2.LeftChild) &&
            Equal(node1.RightChild, node2.RightChild);

        return false;
    }


    //Swap root - to mess with binary search tree
    public void SwapNodes()
    {
        var temp = _root.LeftChild;
        _root.LeftChild = _root.RightChild;
        _root.RightChild = temp;
    }

    public bool isBinarySearchTree()
    {

        return isBinarySearchTree(_root, Int32.MinValue, Int32.MaxValue);
    }

    private bool isBinarySearchTree(Node node, int? min, int? max)
    {

        if (node == null) return true;
        if (node.Value < min || node.Value > max) return false;

        return
            isBinarySearchTree(node.LeftChild, min, node.Value - 1) &&
            isBinarySearchTree(node.RightChild, node.Value + 1, max);
    }

    private List<int> _nodesAtK = new();
    public List<int> NodeAtKLevel(int k)
    {
        NodeAtKLevelRec(_root, k);
        return _nodesAtK;
    }
    private void NodeAtKLevelRec(Node node, int count)
    {
        if (node == null) return;

        if (count == 0)
        {
            _nodesAtK.Add(node.Value);



            return;
        }

        if (node.LeftChild != null)
        {
            //Adding count-- would reassign count to lesser value and will cause problems on the call below
            NodeAtKLevelRec(node.LeftChild, count - 1);
        }

        if (node.RightChild != null)
        {

            NodeAtKLevelRec(node.RightChild, count - 1);
        }
    }

    //BreathFirstSearch - this is a mdumb way to do it probably
    private List<int> breathFirst = new();
    public void BreadthFirst()
    {
        var result = new List<int>();
        for (int i = 0; i < this.Height(); i++)
        {
            var list = NodeAtKLevel(i);
        }
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

