namespace aufgabe_simplelist;

public class Node<T> where T: IComparable
{
    public T Value { get; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}