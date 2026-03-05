namespace aufgabe_simplelist;

public class Set<T> : SimpleList<T> where T: IComparable
{
    public override void Einfuegen(T value)
    {
        if (Suchen(value) == true)
        {
            return;
        }
        
        base.Einfuegen(value);
    }

    public Set<T> Vereinigen(Set<T> value)
    {
        Set <T> vereinigen = new Set<T>();
        
        foreach (T element in ArrayErzeugen())
        {
            vereinigen.Einfuegen(element);
        }

        foreach (T element in value.ArrayErzeugen())
        {
            vereinigen.Einfuegen(element);
        }
        
        return vereinigen;
    }

    public Set<T> SchnittmengeBilden(Set<T> value)
    {
        Set<T> schnittmenge = new Set<T>();
        
        foreach (T element in ArrayErzeugen())
        {
            if (value.Suchen(element) == true)
            {
                schnittmenge.Einfuegen(element);
            }
        }
        
        return schnittmenge;
    }
}