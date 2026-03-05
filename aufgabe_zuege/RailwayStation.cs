namespace aufgabe_zuege;

public class RailwayStation
{
    public string Name { get; set; }
    public int AnzahlMaxWaggons { get; set; }
    
    private List<Train> zuege = new List<Train>();
    
    private int belegteWaggons = 0;

    public RailwayStation(string name, int anzahlMaxWaggons)
    {
        Name = name;
        AnzahlMaxWaggons = anzahlMaxWaggons;
    }

    public void ZugEinfahren(Train train)
    {
        if (belegteWaggons + train.AnzahlWaggons <= AnzahlMaxWaggons)
        {
            zuege.Add(train);
            belegteWaggons += train.AnzahlWaggons;
            Console.WriteLine($"Zug {train.Zugnummer} eingefahren.");
        }

        else
        {
            throw new RailwayStationException("train can't be added", train.Zugnummer);
        }
    }

    public Train ZugAusfahren()
    {
        if (zuege.Count == 0)
        {
            throw new RailwayStationException("no train in railwaystation");
        }
        
        Train ersterZug = zuege[0];
        
        belegteWaggons -= ersterZug.AnzahlWaggons;
        
        zuege.RemoveAt(0);
        
        return ersterZug;
    }
}