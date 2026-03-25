namespace aufgabe_efcore_schneckenrennen;

public class Wette
{
    // Primary Key (automatisch von EF erkannt)
    public int Id { get; set; }
    public string Schneckenname { get; set; }
    public int Wetteinsatz { get; set; }
    public string Spieler { get; set; }


    public Wette()
    {
    }

    public string Ausgabe()
    {
        return $"{Spieler} wettet {Wetteinsatz} Euro auf {Schneckenname}";
    }
}