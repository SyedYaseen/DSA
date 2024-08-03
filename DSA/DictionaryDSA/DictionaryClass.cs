namespace DSA.DictionaryDSA;

public class DictionaryClass
{
    private class Entry
    {
        internal int _key { get; set; }
        internal string _value { get; set; }

        public Entry(int key, string value)
        {
            _key = key;
            _value = value;
        }
    }

    private LinkedList<Entry>[] _dictionary;
    public DictionaryClass()
    {
        _dictionary = new LinkedList<Entry>[5];
    }

    public void Put(int key, string value)
    {
        var position = GetHash(key);
        var entry = new Entry(key, value);

        if (_dictionary[position] == null) _dictionary[position] = new LinkedList<Entry>();

        var Ll = _dictionary[position];

        foreach (var node in Ll)
        {
            if (node._key == key)
            {
                node._value = value;
                return;
            }
        }
        _dictionary[position].AddLast(entry);
    }

    public string Get(int key)
    {
        var position = GetHash(key);
        if (_dictionary[position] == null) throw new NullReferenceException("Doesnt exist");
        var Ll = _dictionary[position];

        foreach (var node in Ll)
        {
            if (node._key == key) return node._value;
        }
        return String.Empty;
    }

    public int GetHash(int key)
    {
        return key % _dictionary.Length;
    }
}