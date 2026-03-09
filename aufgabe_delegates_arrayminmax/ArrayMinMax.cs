namespace aufgabe_delegates_arrayminmax;

public class ArrayMinMax
{
    public int GetLimit(VergleichsHandler vh, int[] zahlenArray)
    {
        int besterIndex = 0;

        for (int i = 0; i < zahlenArray.Length; i++)
        {
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