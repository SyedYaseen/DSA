namespace DSA.TreeDS;

public class TreeClass
{
    private LinkedListNode<int> _root = null;
    private LinkedListNode<int> _leftChild = null;
    private LinkedListNode<int> _rightChild = null;
    private LinkedListNode<int> _current = null;

    public void Insert(int nodeValue)
    {
        if (_root == null) _root = new LinkedListNode<int>(nodeValue);
        _current = _root;
        
        while (_current != null)
        {
            if (nodeValue < _current.Value)
            {
                if (_leftChild == null) _leftChild = new LinkedListNode<int>(nodeValue);
                _current = _leftChild;
            }

            if (nodeValue > _current.Value)
            {
                if (_rightChild == null) _rightChild = new LinkedListNode<int>(nodeValue);
                _current = _rightChild;
            }
        }
    }
}