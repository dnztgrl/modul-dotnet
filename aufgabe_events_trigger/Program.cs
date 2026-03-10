namespace aufgabe_events_trigger;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n===== TEST COUNTER CLASS | LAMBDA =====");
        // Counter mit Lambda-Ausruck als Bedingung erstellt
        Counter c1 = new Counter(x => x >= 1000);
        // Aktion mit Lambda-Ausdruck angemeldet
        c1.Aktion += (sender, e) => Console.WriteLine($"Zählerstand: {e.Zaehlerstand} erreicht.");
        
        c1.ZaehlerstandErhoehen(100);
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        c1.ZaehlerstandErhoehen(800);
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        c1.ZaehlerstandErhoehen(200);
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        
        c1.Clear();
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        
        c1.ZaehlerstandErhoehen(1200);
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        
        Console.WriteLine("\n===== TEST COUNTER ALTERNATIVE CLASS | FUNC & ACTION =====");
        // Counter mit Lambda-Ausruck als Bedingung erstellt
        CounterAlt ac1 = new CounterAlt(x => x >= 1000);
        // Aktion mit Lambda-Ausdruck angemeldet
        ac1.Aktion += (sender, e) => Console.WriteLine($"Zählerstand: {e.Zaehlerstand} erreicht.");
        
        ac1.ZaehlerstandErhoehen(100);
        Console.WriteLine($"Aktueller Zählerstand: {ac1.Zaehlerstand}\n");
        ac1.ZaehlerstandErhoehen(800);
        Console.WriteLine($"Aktueller Zählerstand: {ac1.Zaehlerstand}\n");
        ac1.ZaehlerstandErhoehen(200);
        Console.WriteLine($"Aktueller Zählerstand: {ac1.Zaehlerstand}\n");
        
        ac1.Clear();
        Console.WriteLine($"Aktueller Zählerstand: {c1.Zaehlerstand}\n");
        ac1.ZaehlerstandErhoehen(2000);
        Console.WriteLine($"Aktueller Zählerstand: {ac1.Zaehlerstand}");
    }
}