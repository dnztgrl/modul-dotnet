using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

        // 1. Alle Zahlen echt kleiner als 7
        var echtKleiner7 = numbers.Where(x => x < 7);

        Console.WriteLine("===== ALLE ZAHLEN ECHT KLEINER ALS 7 =====");
        foreach (var n in echtKleiner7)
        {
            Console.WriteLine(n);
        }
        
        // 2. Alle geraden Zahlen
        var alleGeradenZahlen = numbers.Where(x => x % 2 == 0);

        Console.WriteLine("\n===== ALLE GERADEN ZAHLEN =====");
        foreach (var n in alleGeradenZahlen)
        {
            Console.WriteLine(n);
        }
        
        // 3. Alle einstelligen ungeraden Zahlen
        var alleEinstelligenUngeradenZahlen = numbers.Where(x => x % 2 == 1 && x < 10);

        Console.WriteLine("\n===== ALLE EINSTELLIGEN UNGERADEN ZAHLEN");
        foreach (var n in alleEinstelligenUngeradenZahlen)
        {
            Console.WriteLine(n);
        }
        
        // 4. Alle geraden Zahlen ab dem 6. Element (einschließlich) im Array
        var alleGeradenZahlenAbElement6 = numbers.Skip(5).Where(x => x % 2 == 0);

        Console.WriteLine("\n===== ALLE GERADEN ZAHLEN AB DEM 6. ELEMENT (EINSCHLIEßLICH) IM ARRAY");
        foreach (var n in alleGeradenZahlenAbElement6)
        {
            Console.WriteLine(n);
        }

        string[] numberStrings =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen"
        };
        
        // 1. Alle "Zahlen" die drei Zeichen lang sind
        var zahlen3Zeichen = numberStrings.Where(x => x.Length == 3);

        Console.WriteLine("\n===== ALLE \"ZAHLEN\" DIE DREI ZEICHEN LANG SIND");
        foreach (var n in zahlen3Zeichen)
        {
            Console.WriteLine(n);
        }
        
        // 2. Alle "Zahlen" die ein "o" enthalten
        var zahlenMitO = numberStrings.Where(x => x.Contains("o"));

        Console.WriteLine("\n===== ALLE \"ZAHLEN\" DIE EIN \"O\" ENTHALTEN =====");
        foreach (var n in zahlenMitO)
        {
            Console.WriteLine(n);
        }
        
        // 3. Alle "Zahlen" die auf "teen" enden
        var zahlenEndenAufTeen = numberStrings.Where(x => x.EndsWith("teen"));

        Console.WriteLine("\n===== ALLE \"ZAHLEN\" DIE AUF \"TEEN\" ENDEN");
        foreach (var n in zahlenEndenAufTeen)
        {
            Console.WriteLine(n);
        }
        
        // 4. Die Großbuchstabendarstellung aller "Zahlen" die auf "teen" enden
        var zahlenEndenAufTeenGross = numberStrings.Where(x => x.EndsWith("teen")).Select(x => x.ToUpper());

        Console.WriteLine("\n===== DIE GROßBUCHSTABENDARSTELLUNG ALLER \"ZAHLEN\" DIE AUF \"TEEN\" ENDEN");
        foreach (var n in zahlenEndenAufTeenGross)
        {
            Console.WriteLine(n);
        }
        
        // 5. Alle "Zahlen" die "four" enthalten
        var zahlenMitFour = numberStrings.Where(x => x.Contains("four"));

        Console.WriteLine("\n===== ALLE \"ZAHLEN\" DIE \"FOUR\" ENTHALTEN");
        foreach (var n in zahlenMitFour)
        {
            Console.WriteLine(n);
        }
        
        // AUFGABE 2
        // Die Summe aller Werte im Array
        var summeAllerWerte = numbers.Sum();

        Console.WriteLine("\n===== DIE SUMME ALLER WERTE IM ARRAY =====");
        Console.WriteLine(summeAllerWerte);
        
        // Die kleinste Zahl
        var dieKleinsteZahl = numbers.Min();

        Console.WriteLine("\n===== DIE KLEINSTE ZAHL =====");
        Console.WriteLine(dieKleinsteZahl);
        
        // Die größte Zahl
        var dieGroessteZahl = numbers.Max();

        Console.WriteLine("\n===== DIE GRÖßTE ZAHL =====");
        Console.WriteLine(dieGroessteZahl);
        
        // Den Durchschnittswert
        var durchschnitt = numbers.Average();

        Console.WriteLine("\n===== DURCHSCHNITTSWERT =====");
        Console.WriteLine(durchschnitt);
        
        // Die kleinste gerade Zahl
        var kleinsteGeradeZahl = numbers.Where(x => x % 2 == 0).Min();

        Console.WriteLine("\n===== DIE KLEINSTE GERADE ZAHL =====");
        Console.WriteLine(kleinsteGeradeZahl);
        
        // Die größte ungerade Zahl
        var groessteUngeradeZahl = numbers.Where(x => x % 2 == 1).Max();

        Console.WriteLine("\n===== DIE GRÖßTE UNGERADE ZAHL =====");
        Console.WriteLine(groessteUngeradeZahl);
        
        // Die Summe aller geraden Zahlen
        var summeGeraderZahlen = numbers.Where(x => x % 2 == 0).Sum();

        Console.WriteLine("\n===== DIE SUMME ALLER GERADEN ZAHLEN =====");
        Console.WriteLine(summeGeraderZahlen);
        
        // Den Durchschnittswert aller ungeraden Zahlen
        var durchschnittUngeraderZahlen = numbers.Where(x => x % 2 == 1).Average();

        Console.WriteLine("\n===== DURCHSCHNITTSWERT ALLER UNGERADEN ZAHLEN =====");
        Console.WriteLine(durchschnittUngeraderZahlen);
    }
}