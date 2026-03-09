namespace aufgabe_events_warpkern;

public class WarpKernTemperaturEventArgs : EventArgs
{
    private double _alteTemp;
    private double _neueTemp;
    private DateTime _uhrzeit;

    public WarpKernTemperaturEventArgs(double alteTemp, double neueTemp, DateTime uhrzeit)
    {
        _alteTemp = alteTemp;
        _neueTemp = neueTemp;
        _uhrzeit = uhrzeit;
    }

    public double AlteTemp
    {
        get { return _alteTemp; }
    }

    public double NeueTemp
    {
        get { return _neueTemp; }
    }

    public DateTime Uhrzeit
    {
        get { return _uhrzeit; }
    }
}