var numbers = new SimplifiedList();

numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(40);
numbers.Add(50);

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
}