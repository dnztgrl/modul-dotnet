namespace aufgabe_events_beobachteramfluss;

public class Stadt
{
    private string _name;

    public Stadt(string name)
    {
        _name = name;
    }

    // Event Handler - wird aufgerufen, wenn WasserstandUeber8200 ausgelöst wird
    public void AusgabeSchutzwand(object sender, WasserStandEventArgs e)
    {
        Console.WriteLine($"Die Stadt {_name} errichtet eine Wasserschutzwand.");
        Console.WriteLine($"Aktueller Wasserstand: {e.Wasserstand}\n");
    }
}