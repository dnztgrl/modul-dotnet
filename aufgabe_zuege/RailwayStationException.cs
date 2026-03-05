public class RailwayStationException : Exception
{
    public int Zugnummer { get; private set; }
    
    public RailwayStationException(string message, int zugnummer = 0) : base(message)
    {
        Zugnummer = zugnummer;
    }
}