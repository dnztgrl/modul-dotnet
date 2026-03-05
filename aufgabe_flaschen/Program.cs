using aufgabe_flaschen;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" === GENERISCHE FLASCHE | BIER === ");
        Flasche<Getraenk> gb1 = new Flasche<Getraenk>();
        gb1.Fuellen(new Bier("Astra", "Astra St. Pauli Brauerei"));
        Getraenk b1getraenk = gb1.Leeren();
        ((Bier)b1getraenk).GetBierInfo();
        Console.Write("Die Flasche ist ");
        Console.WriteLine(gb1.IstLeer() ? "leer" : "nicht leer");

        Console.WriteLine("\n === GENERISCHE FLASCHE | ROTWEIN | WIRD NICHT GELEERT ===");
        Flasche<Getraenk> rw1 = new Flasche<Getraenk>();
        rw1.Fuellen(new Rotwein("Merlot trocken", "Deutschland"));
        ((Wein)rw1.Inhalt).GetWeinInfo();
        Console.Write("Die Flasche ist ");
        Console.WriteLine(rw1.IstLeer() ? "leer" : "nicht leer");

        Console.WriteLine("\n === GENERISCHE FLASCHE | WEISSWEIN | WIRD GELEERT ===");
        Flasche<Getraenk> ww1 = new Flasche<Getraenk>();
        ww1.Fuellen(new Weisswein("Miguel Torres Waltraud Riesling", "Spanien"));
        Getraenk ww1getraenk = ww1.Leeren();
        ((Wein)ww1getraenk).GetWeinInfo();
        Console.Write("Die Flasche ist ");
        Console.WriteLine(ww1.IstLeer() ? "leer" : "nicht leer");

        Console.WriteLine("\n === GENERISCHE FLASCHE | BIER | WIRD 2X BEFÜLLT | EXCEPTION");
        Flasche<Getraenk> b2 = new Flasche<Getraenk>();
        try
        {
            b2.Fuellen(new Bier("Heineken", "Heineken Brauerei"));
            b2.Fuellen(new Bier("Fiege", "Fiege Brauerei"));
            Getraenk b2getraenk = b2.Leeren();
            ((Bier)b2getraenk).GetBierInfo();
            Console.WriteLine(b2.IstLeer() ? "Flasche ist leer" : "Flasche ist nicht leer");
        }
        
        catch (FlascheException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("\n === GENERISCHE FLASCHE | WEIN | WIRD 2X GELEERT | EXCEPTION");
        Flasche<Getraenk> rw2 = new Flasche<Getraenk>();
        try
        {
            rw2.Fuellen(new Weisswein("Lagrein", "Italien")); 
            rw2.Leeren();
            rw2.Leeren();
        }
        
        catch (FlascheException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}