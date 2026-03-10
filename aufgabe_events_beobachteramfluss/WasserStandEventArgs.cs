namespace aufgabe_events_beobachteramfluss;

public class WasserStandEventArgs
{
    private int _wasserstand;

    public WasserStandEventArgs(int wasserstand)
    {
        _wasserstand = wasserstand;
    }

    public int Wasserstand
    {
        get { return _wasserstand; }
    }
}