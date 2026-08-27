var numbers = new SimplifiedList();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

numbers.RemoveAt(2);

Console.ReadKey();

public class SimplifiedList
{
    private int[] _items = new int[4];
    private int _size = 0;

    public void Add(int item)
    {
        if (_size >= _items.Length)
        {
            var items = new int[_items.Length * 2];
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

        _items[_size] = 0;
    }

    public int GetAtIndex(int index)
    {
        if (index < 0 || index >= _size)
        {
            throw new ArgumentOutOfRangeException($"Index {index} outside the bounds of the list");
        }

        return _items[index];
    }
}