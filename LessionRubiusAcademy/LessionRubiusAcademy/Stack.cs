
    public class Stack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = items[items.Count - 2];
        items.RemoveAt(items.Count - 2);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[items.Count - 2];
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public void Clear()
    {
        items.Clear();
    }
}
