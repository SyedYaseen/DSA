namespace DSA.HeapDSA;

public class Heapify
{
    List<int> beforeHeap = new List<int> { 5, 3, 8, 4, 1, 2 };

    /*
     * Iterate through the list
     * Start a recursive loop when item at current index is less than left/right child index
     * Recursive loop will bubble down the current index until children are smaller than the current item
     *
     * Optimization:
     * Mathematically half of nodes on a head are nodes with no children, so we dont need to heapify there
     * So we can stop the for loop at the last parent. Since half - 1 will the last node we can stop the
     * for loop at list.count() /2 -1
     *
     * Dont know why but apparently if I go from bottom to top I will have fewer swaps/ recursions so for loop runs in reverse
     */

    public List<int> DoHeap()
    {
        var size = beforeHeap.Count();
        var lastParent = size / 2 - 1;
        if (size <= 1) return beforeHeap;

        for (var index = lastParent; index >= 0; index--)
        {
            var current = beforeHeap[index];
            var largestIndex = GetLargestIndex(index);

            while (current < beforeHeap[largestIndex])
                Swap(index, largestIndex);
        }

        return beforeHeap;
    }

    private void Swap(int index, int largestIndex)
    {
        var temp = beforeHeap[index];
        beforeHeap[index] = beforeHeap[largestIndex];
        beforeHeap[largestIndex] = temp;
    }

    private int GetLargestIndex(int index)
    {
        var size = beforeHeap.Count();
        var lcIndex = GetLeftChildIndex(index);
        var rcIndex = GetRightChildIndex(index);

        if (lcIndex > size - 1) return index;
        if (rcIndex > size - 1) return lcIndex;

        return beforeHeap[lcIndex] > beforeHeap[rcIndex] ? lcIndex : rcIndex;
    }

    public int GetLeftChildIndex(int index) => (index * 2) + 1;
    public int GetRightChildIndex(int index) => (index * 2) + 2;

}