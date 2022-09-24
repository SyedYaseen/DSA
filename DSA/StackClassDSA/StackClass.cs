using System.Collections;
using DSA.ArrayDSA;

namespace DSA.StackClassDSA;

public class StackClass
{
    private int _count = -1;
    private int[] stack;
    private int _size = 0;
    public StackClass(int size)
    {
        _size = size;
        stack = new int[size];
    }

    public void Push(int value)
    {
        if (_count < _size - 1) stack[++_count] = value;
        
        else
        {
            NewStack();
            Push(value);
        }
    }


    private void NewStack()
    {
        _size = _size * 2;
        var newStack = new int[_size];
        for (int i = 0; i < _count; i++)
        {
            newStack[i] = stack[i];
        }
        stack = newStack;
    }

    public int Pop()
    {
        if (_count > -1) return stack[_count--];
        else throw new IndexOutOfRangeException();
    }

    public int Peek()
    {
        if (_count > -1) return stack[_count];
        else throw new NullReferenceException();
    }

    public bool IsEmpty()
    {
        return _count > -1 ? true : false;
    }
    
    
    
    public Stack<char> BracketStack = new Stack<char>();
    public List<char> BracketsList = new List<char> { '{', '}', '<', '>', '(', ')'};

    public Dictionary<char, char> Brackets = new Dictionary<char, char>()
    {
        {'{', '}'},
        {'(', ')'},
        {'<', '>'}
    };

    public bool MatchBrackets(string value)
    {
        foreach (var character in value)
        {
            if (Brackets.ContainsKey(character) || Brackets.ContainsValue(character))
            {
                if (BracketStack.Count != 0)
                { 
                    if (Brackets[BracketStack.Peek()] == character) BracketStack.Pop();
                }
                else BracketStack.Push(character);
            }
        }

        if (BracketStack.Count == 0) return true;
        else return false;
    }
}