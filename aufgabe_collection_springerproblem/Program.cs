namespace aufgabe_collection_springerproblem;

public class Program
{
    public static void Main(string[] args)
    {
        SpringerTour s = new SpringerTour();

        try
        {
            s.ZeigeSpielbrett();
            s.SetzeStartPosition();
            s.StarteSpringerTour();
            s.ZeigeSpielbrett();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}