namespace aufgabe_efcore_schneckenrennen;

public class Rennschnecke
{
    // Primary Key (automatisch von EF erkannt)
    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxGeschwindigkeit { get; set; }
    public int Strecke { get; set; }

    private static Random rnd = new Random();
    
    public Rennschnecke()
    {
    }

    public void Krieche()
    {
        int fortschritt = 0;
        fortschritt = rnd.Next(1, (int)MaxGeschwindigkeit + 1);
        Strecke += fortschritt;
    }

    public string Ausgabe()
    {
        return $"🐌: {Name,-12} | Speed: {MaxGeschwindigkeit,-3} | Strecke: {Strecke}";
    }
}