namespace aufgabe_simplelist;

public class SimpleList<T> where T: IComparable
{
    private Node<T> head;

    public virtual void Einfuegen(T value)
    {
        if (head == null)
        {
            head = new Node<T>(value);
            return;
        }
        
        Node<T> current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }
        
        current.Next = new Node<T>(value);
    }

    public bool Loeschen(T value)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Value.CompareTo(value) == 0)
        {
            head = head.Next;
            return true;
        }

        Node<T> current = head;
        Node<T> previous = null;
        
        while (current != null && current.Value.CompareTo(value) != 0) 
        {
            previous = current;
            current = current.Next;
        }
        
        if (current == null)
        {
            return false;
        }

        previous.Next = current.Next;

        return true;
    }

    public bool Suchen(T value)
    {
        Node<T> current = head;
        
        while (current != null && current.Value.CompareTo(value) != 0) 
        {
            current = current.Next;
        }

        if (current == null)
        {
            return false;
        }

        return true;
    }

    public int AnzahlElemente()
    {
        Node<T> current = head;
        int counter = 0;
        
        while (current != null) 
        {
            current = current.Next;
            counter++;
        }

        return counter;
    }

    public T[] ArrayErzeugen()
    {
        T[] array = new T[AnzahlElemente()];
        
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