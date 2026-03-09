namespace aufgabe_events_warpkern;

// Delegate-Typen für beide Events
public delegate void TemperaturAenderungEventHandler(object sender, WarpKernTemperaturEventArgs e);
public delegate void UeberhitzungsWarnungEventHandler(object sender, WarpKernTemperaturEventArgs e);

public class WarpKern
{
    private double _warpkernTemperatur;
    
    // Events, die Subscriber abonnieren können
    public event TemperaturAenderungEventHandler TemperaturAenderung;
    public event UeberhitzungsWarnungEventHandler UeberhitzungsWarnung;

    public double WarpkernTemperatur
    {
        get { return _warpkernTemperatur; }
        set
        {
            if (_warpkernTemperatur == value)
            {
                return;
            }
            
            // Event-Args mit alter Temperatur, neuer Temperatur und aktueller Uhrzeit erstellen
            WarpKernTemperaturEventArgs e = new WarpKernTemperaturEventArgs(_warpkernTemperatur, value, DateTime.Now);

            // Temperaturänderungs-Event auslösen, wenn Subscriber vorhanden
            if (TemperaturAenderung != null)
            {
                TemperaturAenderung(this, e);
            }

            // Überhitzungswarnung-Event auslösen, wenn Subscriber vorhanden & Temperatur > 500
            if (value > 500 && UeberhitzungsWarnung != null)
            {
                UeberhitzungsWarnung(this, e);
            }

            _warpkernTemperatur = value;
        }
    }
}