namespace aufgabe_events_beobachteramfluss;

public class WasserStandEventArgs : EventArgs
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