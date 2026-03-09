namespace aufgabe_events_warpkern;

public class WarpkernKonsole
{
    // Event-Handler für Temperaturänderungen
    public void AusgabeTemperaturAenderung(object sender, WarpKernTemperaturEventArgs e)
    {
        Console.WriteLine($"Alte Temperatur: {e.AlteTemp}");
        Console.WriteLine($"Neue Temperatur: {e.NeueTemp}");
        Console.WriteLine($"Uhrzeit: {e.Uhrzeit.ToLongTimeString()}\n");
    }

    // Event-Handler für Überhitzungwarnung
    public void AusgabeUeberhitzungswarnung(object sender, WarpKernTemperaturEventArgs e)
    {
        Console.WriteLine($"Überhitzungswarnung!\nAktuelle Temperatur: {e.NeueTemp}\n");
    }
}