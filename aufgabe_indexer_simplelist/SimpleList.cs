namespace aufgabe_indexer_simplelist;

public class SimpleList<T> where T: IComparable
{
    private Node<T> head;
    public int anzahlElemente { get; private set; }

    public T this[int index]
    {
        get
        {
            Node<T> current = head;
            
            if (index < 0 || index >= anzahlElemente)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            
            return current.Value;
        }
    }
    
    public void Add(T value)
    {
        if (head == null)
        {
            head = new Node<T>(value);
        }

        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            
            current.Next = new Node<T>(value);
        }
        
        anzahlElemente++;
    }

    public void Remove(T value)
    {
        if (head == null)
        {
            return;
        }
        
        if (head.Value.CompareTo(value) == 0)
        {
            head = head.Next;
            anzahlElemente--;
        }

        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.CompareTo(value) == 0)
                {
                    current.Next = current.Next.Next;
                    anzahlElemente--;
                    break;
                }

                else
                {
                    current = current.Next;
                }
            }
        }
    }

    public int Search(T value)
    {
        Node<T> current = head;
        int index = 0;

        while (current != null)
        {
            if (current.Value.CompareTo(value) == 0)
            {
                return index;
            }

            else
            {
                current = current.Next;
                index++;
            }
        }

        return -1;
    }
    
    public int Count => anzahlElemente;

    public T[] CreateArray()
    {
        T[] array = new T[anzahlElemente];

        Node<T> current = head;
        int index = 0;

        while (current != null)
        {
            array[index] = current.Value;
            current = current.Next;
            index++;
        }

        return array;
    }
}