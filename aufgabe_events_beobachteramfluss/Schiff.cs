namespace aufgabe_events_beobachteramfluss;

public class Schiff
{
    private string _name;

    public Schiff(string name)
    {
        _name = name;
    }

    // Event Handler - wird aufgerufen, wenn WasserstandUnter250 oder WasserstandUeber8000 ausgelöst wird
    public void AusgabeFahrtstop(object sender, WasserStandEventArgs e)
    {
            Console.WriteLine($"Das Schiff {_name} hält an.");
            Console.WriteLine($"Aktueller Wasserstand: {e.Wasserstand}\n");
    }
}