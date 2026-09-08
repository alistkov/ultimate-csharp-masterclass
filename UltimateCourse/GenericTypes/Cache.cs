namespace UltimateCourse.GenericTypes;

public class Cache<TKey, TData> where TKey : notnull
{
    private readonly Dictionary<TKey, TData> _cachedData = new();

    public TData Get(TKey key, Func<TKey, TData> getForTheFirstTime)
    {
        if (!_cachedData.ContainsKey(key))
        {
            _cachedData[key] = getForTheFirstTime(key);
        }

        return _cachedData[key];
    }
}