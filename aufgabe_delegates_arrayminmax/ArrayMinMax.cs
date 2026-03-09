namespace aufgabe_delegates_arrayminmax;

public class ArrayMinMax
{
    public int GetLimit(VergleichsHandler vh, int[] zahlenArray)
    {
        // Index 0 ist vorerst der beste
        int besterIndex = 0;
        
        // Sucht den Index des kleinsten und des größten Wertes im Array
        // Der Delegate bestimmt, ob nach Mininum oder Maximum gesucht wird
        for (int i = 0; i < zahlenArray.Length; i++)
        {
            // Delegate entscheidet, ob aktuelles Element besser ist als bisheriger Bestwert
            if (vh(zahlenArray[i], zahlenArray[besterIndex]))
            {
                besterIndex = i;
            }
        }
        
        return besterIndex;
    }

    public bool IstKleiner(int a, int b)
    {
        return a < b;
    }

    public bool IstGroesser(int a, int b)
    {
        return a > b;
    }
}