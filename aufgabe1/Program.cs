using aufgabe1;

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        
        p.Name = "Max";
        p.Vorname = "Mustermann";
        p.Alter = 25;
        
        Person p2 = new Person();

        try
        {
            p2.Name = "Max";
            p2.Vorname = "Mustermann";
            p2.Alter = -10;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}