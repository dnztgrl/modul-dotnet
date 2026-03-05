using aufgabe_indexer_simplelist;

class Program
{
    static void Main(string[] args)
    {
        // ARRAY ERSTELLEN
        SimpleList<int> list = new SimpleList<int>();
        
        // ARRAY FÜLLEN
        list.Add(20);
        list.Add(10);
        list.Add(30);

        // ANZAHL DER ELEMENTE AUSGEBEN
        Console.WriteLine("\n\n===== ANZAHL DER ELEMENTE =====");
        Console.WriteLine($"Anzahl der Elemente: {list.Count}");

        // ELEMENTE VIA INDEX AUSGEBEN
        Console.WriteLine("\n\n===== ELEMENTE VIA INDEX =====");
        Console.WriteLine($"Element an Index 0: {list[0]}");
        Console.WriteLine($"Element an Index 1: {list[1]}");
        Console.WriteLine($"Element an Index 2: {list[2]}");

        // ELEMENTE SUCHEN
        Console.WriteLine("\n\n===== ELEMENTE SUCHEN =====");
        int gesuchterIndex = list.Search(30);
        Console.WriteLine($"Gesuchtes Element: {list[gesuchterIndex]}");
        Console.WriteLine($"Position des gesuchten Elements: {gesuchterIndex}");
        
        // ELEMENTE LÖSCHEN
        Console.WriteLine("\n\n===== ELEMENTE LÖSCHEN =====");
        Console.WriteLine("Gelöschtes Elemente: 20");
        list.Remove(20);
        Console.WriteLine($"Anzahl der Elemente: {list.Count}");
        Console.WriteLine($"\nElement an Index 0: {list[0]}");
        Console.WriteLine($"Element an Index 1: {list[1]}");
        
        // NEUES ARRAY VIA METHODE ERSTELLEN
        Console.WriteLine("\n\n===== NEUES ARRAY VIA METHODE ERSTELLEN =====");
        int[] list2 = list.CreateArray();

        Console.WriteLine($"Erstes Element im neuen Array: {list2[0]}");

        Console.WriteLine("\n\n===== EXCEPTION TEST =====");
        
        try
        {
            int fehler = list[2];
        }
        
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}