using aufgabe_simplelist;

public class Program
{
    static void Main(string[] args)
    {
        // ARRAY ERSTELLEN
        SimpleList<int> list = new SimpleList<int>();
        
        // WERTE HINZUFÜGEN
        list.Einfuegen(1);
        list.Einfuegen(2);
        list.Einfuegen(3);
        list.Einfuegen(4);
        list.Einfuegen(5);
        list.Einfuegen(6);
        list.Einfuegen(7);
        list.Einfuegen(8);
        list.Einfuegen(9);
        list.Einfuegen(10);
        
        // WERTE LÖSCHEN + AUSGABE
        Console.WriteLine(" === WERTE LÖSCHEN ===");
        Console.WriteLine(list.Loeschen(2) ? $"Wert erfolgreich gelöscht" : "Wert nicht gefunden");
        Console.WriteLine(list.Loeschen(5) ? "Wert erfolgreich gelöscht" : "Wert nicht gefunden");
        Console.WriteLine(list.Loeschen(8) ? "Wert erfolgreich gelöscht" : "Wert nicht gefunden");
        Console.WriteLine(list.Loeschen(12) ? "Wert erfolgreich gelöscht" : "Wert nicht gefunden");
        
        // WERTE SUCHEN + AUSGABE
        Console.WriteLine("\n === WERTE SUCHEN === ");
        Console.WriteLine(list.Suchen(1) ? "Wert gefunden" : "Wert nicht gefunden");
        Console.WriteLine(list.Suchen(10) ? "Wert gefunden" : "Wert nicht gefunden");
        Console.WriteLine(list.Suchen(11) ? "Wert gefunden" : "Wert nicht gefunden");

        // ANZAHL ELEMENTE AUSGABE
        Console.WriteLine($"\nAnzahl Elemente: " + list.AnzahlElemente());

        // ARRAY AUSGABE
        Console.Write("\nArray: ");
        foreach (int element in list.ArrayErzeugen())
        {
            Console.Write(element + " ");
        }
        
        // SET ERSTELLEN
        Set<int> set = new Set<int>();
        
        // WERTE HINZUFÜGEN & TEST DOPPELTE ELEMENTE
        set.Einfuegen(1);
        set.Einfuegen(1); // DOPPELT
        set.Einfuegen(2);
        set.Einfuegen(3);
        set.Einfuegen(4);
        set.Einfuegen(5);
        set.Einfuegen(5); // DOPPELT
        set.Einfuegen(6);
        set.Einfuegen(7);
        set.Einfuegen(8);
        set.Einfuegen(9);
        set.Einfuegen(9); // DOPPELT
        set.Einfuegen(10);
        
        // ARRAY AUSGABE
        Console.WriteLine("\n\n=== TEST DOPPELTE ELEMENTE ===");
        Console.Write("Array: ");
        foreach (int element in set.ArrayErzeugen())
        {
            Console.Write(element + " ");
        }
        
        // ZWEITES SET + WERTE HINZUFÜGEN
        Set<int> zweitesSet = new Set<int>();
        zweitesSet.Einfuegen(1);
        zweitesSet.Einfuegen(2);
        zweitesSet.Einfuegen(5);
        zweitesSet.Einfuegen(7);
        zweitesSet.Einfuegen(8);
        zweitesSet.Einfuegen(9);
        zweitesSet.Einfuegen(10);
        zweitesSet.Einfuegen(11);
        zweitesSet.Einfuegen(12);
        zweitesSet.Einfuegen(13);
        
        // VEREINIGUNG AUSGABE
        Set<int> vereinigteSet = set.Vereinigen(zweitesSet);

        Console.WriteLine("\n\n === VEREINIGUNG ===");
        Console.Write("Array: ");
        foreach (int element in vereinigteSet.ArrayErzeugen())
        {
            Console.Write(element + " ");
        }
        
        // SCHNITTMENGE AUSGABE
        Set<int> schnittmenge = set.SchnittmengeBilden(zweitesSet);

        Console.WriteLine("\n\n === SCHNITTMENGE ===");
        Console.Write("Array: ");
        foreach (int element in schnittmenge.ArrayErzeugen())
        {
            Console.Write(element + " ");
        }
    }
}