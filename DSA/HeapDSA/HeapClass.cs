namespace DSA.HeapDSA;

public class HeapClass
{
    public List<int> _heap = new();
    private int size;

    public void Insert(int value)
    {
        _heap.Add(value);

        var currentIndex = _heap.Count() - 1;
        var parentIndex = GetParentIndex(currentIndex);

        Insert(value, parentIndex, currentIndex);
    }

    public void Insert(int value, int parentIndex, int currentIndex)
    {
        if (parentIndex == -1 || currentIndex == 0) return;
        var parentValue = _heap[parentIndex];

        if (value > parentValue)
        {
            _heap[parentIndex] = value;
            _heap[currentIndex] = parentValue;
            var innerParentIndex = GetParentIndex(parentIndex);
            Insert(value, innerParentIndex, parentIndex);
        }
    }

    public void Remove()
    {
        if (_heap.Count == 0) throw new ArgumentNullException();

        //Not sure why but is how heap works
        _heap[0] = _heap.Last();
        _heap.RemoveAt(_heap.Count() - 1);

        //Compare left and right child index
        var index = 0;
        while (index <= _heap.Count() - 1 &&
               _heap[index] < LeftChildAt(index) &&
               _heap[index] < RightChildAt(index))
        {


            var largestChildIndex = LargestChildIndex(index);


            var tmp = _heap[index];
            _heap[index] = _heap[largestChildIndex];
            _heap[largestChildIndex] = tmp;
            index = largestChildIndex;
        }
    }

    private int LargestChildIndex(int index)
    {
        if (LeftChild(index) > _heap.Count() - 1) return index;
        if (RightChild(index) > _heap.Count() - 1) return LeftChildAt(index);

        return LeftChildAt(index) > RightChildAt(index) ?
            LeftChild(index) : RightChild(index);
    }


    private int LeftChildAt(int index)
    {
        return _heap[LeftChild(index)];
    }

    private int RightChildAt(int index)
    {
        return _heap[RightChild(index)];
    }

    private int LeftChild(int index)
    {
        return (index * 2) + 1;
    }

    private int RightChild(int index)
    {
        return (index * 2) + 2;
    }


    private int GetParentIndex(int index)
    {
        if (index == 1) return 0;
        int val = index - 2;

        if (val % 2 == 0)
        {
            return val / 2;
        }
        if (val % 2 != 0)
        {
            return (val / 2) + 1;
        }

        // double res = Math.Ceiling((index - 2) / 2);
        // Console.WriteLine(res);
        return -1;
    }


}