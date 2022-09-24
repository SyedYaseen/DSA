namespace DSA.ArrayDSA;

public class TwoStacksOneArray
{
    private int _size;
    public int[] stack;
    private int _count1 = -1;
    private int _count2 = 0;
    
    public TwoStacksOneArray(int size)
    {
        _size = size;
        stack = new int[_size];
    }

    public void Push1(int value)
    {
        if (_count1 < _size - 2)
        {
            _count1 += 2;
            stack[_count1] = value;
            
        }
        
        else
        {
            NewStack();
            Push1(value);
        }
    }
    
    public void Push2(int value)
    {
        if (_count2 < _size - 2)
        {
            _count2 += 2;
            stack[_count2] = value;
        }
        
        else
        {
            NewStack();
            Push2(value);
        }
    }

    public int Pop1()
    {
        int result;
        if (_count1 != -1)
        {
            result = stack[_count1];
            _count1 -= 2;
        }

        else result = 99;

        return result;
    }
    
    public int Pop2()
    {
        int result;
        if (_count2 != 0)
        {
            result = stack[_count2];
            _count2 -= 2;
        }

        else result = 99;

        return result;
    }
    
    public int Peek1()
    {
        int result;
        if (_count1 != -1)
        {
            result = stack[_count1];
        }

        else result = 99;

        return result;
    }
    
    public int Peek2()
    {
        int result;
        if (_count2 != 0)
        {
            result = stack[_count2];
        }

        else result = 99;

        return result;
    }
    
    
    private void NewStack()
    {
        _size = _size * 2;
        var newStack = new int[_size];

        var len = _count1 > _count2 ? _count1 : _count2;
        
        for (int i = 0; i < len; i++)
        {
            newStack[i] = stack[i];
        }
        stack = newStack;
    }
}