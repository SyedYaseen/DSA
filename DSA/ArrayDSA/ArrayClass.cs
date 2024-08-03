namespace DSA.ArrayDSA;

public class ArrayClass<T> where T : IEquatable<T>
{
    private T[] _items;
    private int count;

    public ArrayClass(int size)
    {
        _items = new T[size];
    }

    public void PrintItems()
    {
        for (int i = 0; i < _items.Length; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }

    public void Insert(T item)
    {
        if (count < _items.Length)
        {
            _items[count] = item;
            count++;
        }
        else
        {
            var longerList = CreateLongerList();
            MoveItems(longerList);
            Insert(item);
        }
    }

    private T[] CreateLongerList(int index = 0)
    {
        if (index == 0) return new T[_items.Length * 2];
        else return new T[(index + 1) * 2];
    }

    private void MoveItems(T[] newItems)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            newItems[i] = _items[i];
        }
        _items = newItems;
    }

    private int IndexOf(T item)
    {
        for (int i = 0; i < _items.Length; i++)
        {
            if (EqualityComparer<T>.Default.Equals(item, _items[i])) return i;
        }
        return -1;
    }

    public int Delete(T item)
    {
        var index = IndexOf(item);
        if (index > -1)
        {
            for (int i = index; i < _items.Length - 1; i++)
            {
                _items[i] = _items[i + 1];
                count--;
            }
            return 1;
        }
        return index;
    }

    public int InsertAt(T item, int index)
    {
        var arrLength = _items.Length;
        if (index > arrLength)
        {
            MoveItems(CreateLongerList(index));
            _items[index] = item;
            count = arrLength;
        }
        else
        {
            _items[index] = item;
        }
        return -1;
    }


    public static ArrayClass<T> Intersect(T[] arr1, T[] arr2)
    {
        var dict = new Dictionary<T, int>();
        var resultArr = new ArrayClass<T>(arr1.Length > arr2.Length ? arr1.Length : arr2.Length);
        for (int i = 0; i < arr1.Length; i++)
        {
            if (dict.ContainsKey(arr1[i])) dict[arr1[i]] += 1;
            else dict[arr1[i]] = 1;
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            if (dict.ContainsKey(arr2[i]) && resultArr.IndexOf(arr2[i]) == -1)
            {
                resultArr.Insert(arr2[i]);
            }
        }

        return resultArr;
    }

}