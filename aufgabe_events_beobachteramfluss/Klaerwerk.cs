namespace aufgabe_events_beobachteramfluss;

public class Klaerwerk
{
    private string _name;

    public Klaerwerk(string name)
    {
        _name = name;
    }

    // Event Handler - wird aufgerufen, wenn WasserstandUeber8000 ausgelöst wird
    public void AusgabeEinleitungStop(object sender, WasserStandEventArgs e)
    {
        Console.WriteLine($"Das Klärwerk {_name} stoppt seine Einleitungen.");
        Console.WriteLine($"Aktueller Wasserstand: {e.Wasserstand}\n");
    }

    // Event Handler - wird aufgerufen, wenn WasserstandUnter3000 ausgelöst wird
    public void AusgabeEinleitungSteigern(object sender, WasserStandEventArgs e)
    {
        Console.WriteLine($"Das Klärwerk {_name} steigert seine Einleitungen.");
        Console.WriteLine($"Aktueller Wasserstand: {e.Wasserstand}\n");
    }
}