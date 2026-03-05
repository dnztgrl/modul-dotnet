namespace aufgabe_flaschen;

public class Bier : Getraenk
{
    private string Brauerei { get; set; }

    public Bier(string name, string brauerei) : base(name)
    {
        Brauerei = brauerei;
    }

    public string GetBrauerei()
    {
        return Brauerei;
    }

    public void GetBierInfo()
    {
        Console.WriteLine($"Name: {Name}\nBrauerei: {Brauerei}\n");
    }
}