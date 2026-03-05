using aufgabe_zuege;

class Program
{
    static void Main(string[] args)
    {
        RailwayStation station = new RailwayStation("Bochum Hbf", 10);

        Console.WriteLine($"--- Starte Szenario-Test für {station.Name} ---");
        
        Console.WriteLine("\nSzenario 1: Züge parken...");
        try
        {
            station.ZugEinfahren(new Train(101, 4));
            station.ZugEinfahren(new Train(102, 4)); 
            Console.WriteLine("Züge 101 und 102 erfolgreich eingefahren.");
        }
        catch (RailwayStationException e)
        {
            Console.WriteLine($"Unerwarteter Fehler: {e.Message}");
        }

        
        Console.WriteLine("\nSzenario 2: Kapazität testen...");
        try
        {
            station.ZugEinfahren(new Train(999, 3)); 
        }
        catch (RailwayStationException e) when (e.Zugnummer > 0)
        {
            Console.WriteLine($"Erwarteter Fehler: {e.Message} (Zugnummer: {e.Zugnummer})");
        }
        
        
        Console.WriteLine("\nSzenario 3: Züge ausfahren (FIFO)...");
        try
        {
            Train ausgefahren1 = station.ZugAusfahren();
            Console.WriteLine($"Zug {ausgefahren1.Zugnummer} ist ausgefahren.");
            Train ausgefahren2 = station.ZugAusfahren();
            Console.WriteLine($"Zug {ausgefahren2.Zugnummer} ist ausgefahren.");
        }
        catch (RailwayStationException e)
        {
            Console.WriteLine($"Fehler beim Ausfahren: {e.Message}");
        }
        
        Console.WriteLine("\nSzenario 4: Leeren Bahnhof testen...");
        try
        {
            station.ZugAusfahren();
        }
        catch (RailwayStationException e)
        {
            Console.WriteLine($"Erwarteter Fehler: {e.Message}");
        }

        Console.WriteLine("\n--- Alle Tests beendet ---");
        Console.ReadLine();
    }
}