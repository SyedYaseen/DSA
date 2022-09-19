using System.Collections;

namespace DSA.StackClassDSA;

public class StackClass
{
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