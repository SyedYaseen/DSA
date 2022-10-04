namespace DSA.DictionaryDSA;

public class FirstNonRepeatedCharacter
{
    private Dictionary<char, int> _dictionary;
    
    public FirstNonRepeatedCharacter()
    {
        _dictionary = new Dictionary<char, int>();
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
}