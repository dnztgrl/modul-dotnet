namespace aufgabe_events_trigger;

public class CounterAlt
{
    private int _zaehlerstand;

    // Func - nimmt int und gibt bool zurück
    private Func<int, bool> _bedingung;
    
    // ersetzt den AktionEventHandler
    public event Action<object, CounterEventArgs> Aktion;

    public int Zaehlerstand
    {
        get { return _zaehlerstand; }
    }
    
    public CounterAlt(Func<int, bool> Bedingung)
    {
        _bedingung = Bedingung;
    }
    
    public void ZaehlerstandErhoehen(int x)
    {
        _zaehlerstand += x;
        if (_bedingung(_zaehlerstand))
        {
            Aktion?.Invoke(this, new CounterEventArgs(_zaehlerstand));
        }
    }

    public void Clear()
    {
        _zaehlerstand = 0;
    }
}