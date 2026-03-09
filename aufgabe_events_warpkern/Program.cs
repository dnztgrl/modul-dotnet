namespace aufgabe_events_warpkern;

class Program
{
    static void Main(string[] args)
    {
        // Broadcaster und Subscriber erstellen
        WarpKern wp = new WarpKern();
        WarpkernKonsole wpk = new WarpkernKonsole();

        // Subscriber bei den Events des Broadcasters anmelden
        wp.TemperaturAenderung += wpk.AusgabeTemperaturAenderung;
        wp.UeberhitzungsWarnung += wpk.AusgabeUeberhitzungswarnung;

        // Normale Temperaturen testen
        Console.WriteLine("===== TEST TEMPERATURÄNDERUNG =====");
        wp.WarpkernTemperatur = 100;
        wp.WarpkernTemperatur = 250;

        // Überhitzungswarnung testen (Temp > 500 Grad)
        Console.WriteLine("===== TEST ÜBERHITZUNGSWARNUNG =====");
        wp.WarpkernTemperatur = 550;
        wp.WarpkernTemperatur = 750;

        wp.WarpkernTemperatur = 300;

    }
}