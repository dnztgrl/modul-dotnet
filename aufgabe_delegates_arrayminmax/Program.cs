namespace aufgabe_delegates_arrayminmax;

public delegate bool VergleichsHandler(int x, int y);

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] zufallsZahlen = new int[10];

        for (int i = 0; i < zufallsZahlen.Length; i++)
        {
            zufallsZahlen[i] = rnd.Next(0, 100);
        }

        ArrayMinMax arrayMinMax = new ArrayMinMax();
        
        int minIndex = arrayMinMax.GetLimit(arrayMinMax.IstKleiner, zufallsZahlen);
        Console.WriteLine($"Kleinster Wert: {zufallsZahlen[minIndex]} an Index {minIndex}");

        int maxIndex = arrayMinMax.GetLimit(arrayMinMax.IstGroesser, zufallsZahlen);
        Console.WriteLine($"Größter Wert: {zufallsZahlen[maxIndex]} an Index {maxIndex}");
    }
}