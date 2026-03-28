namespace Week8;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item) => _items.Add(item);

    public long GetTotalSize()
    {
        long sum = 0;
        foreach (T item in _items)
        {
            sum += item.GetSize();
        }

        return sum;
    }
}