namespace DSA.DictionaryDSA;

public class RepeatedCharacter
{
    private Dictionary<char, int> _dictionary;
    private Dictionary<int, int> _intDictionary;
    
    private HashSet<char> _set;

    public RepeatedCharacter()
    {
        _dictionary = new Dictionary<char, int>();
        _intDictionary = new Dictionary<int, int>();
        _set = new HashSet<char>();

    }

    public char FirstRepeatedChar(string value)
    {
        char result = ' ';
        foreach (var i in value)
        {
            if (_set.Contains(i)) return i;
            _set.Add(i);
        }
        return Char.MinValue;
    }
    
    public char FindNonRepeatedChar(string value)
    {
        char result = ' ' ;
        foreach (var i in value)
        {
            if (!_dictionary.ContainsKey(i))
            {
                _dictionary.Add(i, 1);
                continue;
            }
            _dictionary[i] += 1;
        }

        foreach (var i in value)
        {
            if (_dictionary[i] == 1)
            {
                result = i;
                break;
            }
        }
        return result;
    }

    public int FindMostRepeatedElement(char[] arr)
    {
        var result = 0;
        foreach (var i in arr)
        {
            if (_dictionary.ContainsKey(i))
            {
                _dictionary[i] += 1;
                result = result < _dictionary[i] ? _dictionary[i] : result;
            }
            
            else _dictionary.Add(i, 1);
        }
        return result;
    }

    public int CountPairsWithDiff(int[] arr, int diff)
    {
        //[1, 7, 5, 9, 2, 12, 3] K=2
        var result = 0;
        foreach (var i in arr)
        {
            if (_intDictionary.ContainsKey(i + diff))
            {
                // _intDictionary[i] += 1;
                result++;
            }
            
            else _intDictionary.Add(i, 1);
        }
        
        return result;
    }
}