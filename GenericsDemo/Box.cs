namespace GenericsDemo;

public class Box<T>
{
    private T _item;

    public Box(T value)
    {
        _item = value;
    }

    public T GetItem()
    {
        return _item;
    }
}
