namespace aufgabe_flaschen;

public class Wein : Getraenk
{

    protected string Herkunft{ get; set; }
    public Wein(string name, string herkunft) : base(name)
    {
        Herkunft = herkunft;
    }

    public string GetHerkunft()
    {
        return Herkunft;
    }

    public void GetWeinInfo()
    {
        Console.WriteLine($"Name: {Name}\nHerkunft: {Herkunft}\n");
    }
}