namespace aufgabe_flaschen;

public class Flasche<T> where T: Getraenk
{
    public T Inhalt { get; set; }

    public bool IstLeer()
    {
        if (Inhalt == null)
        {
            return true;
        }

        return false;
    }

    public void Fuellen(T getraenk)
    {
        if (!IstLeer())
        {
            throw new FlascheException("Flasche ist bereits befüllt und kann nicht nochmal befüllt werden!");
        }
        
        Inhalt = getraenk;
    }

    public T Leeren()
    {
        if (IstLeer())
        {
            throw new FlascheException("Flasche ist bereits leer und kann nicht geleert werden!");
        }
        
        T getraenk = Inhalt;
        Inhalt = default(T);
        return getraenk;
    }
}