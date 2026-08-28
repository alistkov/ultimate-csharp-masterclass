var numbers = new SimplifiedList<int>();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

numbers.RemoveAt(2);

var words = new SimplifiedList<string>();

words.Add("aaa");
words.Add("bbb");
words.Add("ccc");
words.Add("ddd");
words.Add("eee");

Console.ReadKey();

public class SimplifiedList<T>
{
    private T[] _items = new T[4];
    private int _size = 0;

    public void Add(T item)
    {
        if (_size >= _items.Length)
        {
            var items = new T[_items.Length * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                items[i] = _items[i];
            }

            _items = items;
        }

        _items[_size] = item;
        _size += 1;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > _size)
        {
            throw new ArgumentOutOfRangeException($"Index {index} outside the bounds of the list");
        }

        _size -= 1;

        for (int i = index; i < _size; i += 1)
        {
            _items[i] = _items[i + 1];
        }

        _items[_size] = default;
    }

    public T GetAtIndex(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new ArgumentOutOfRangeException($"Index {index} outside the bounds of the list");
        }

        return _items[index];
    }
}