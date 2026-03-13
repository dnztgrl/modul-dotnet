namespace aufgabe_erweiterungsmethoden_stringextension;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie eine Zahl ein: ");
        string s = Console.ReadLine();
        Console.WriteLine(s.ToInt32());

        Console.WriteLine("\nGeben Sie ein Wort ein: ");
        s = Console.ReadLine();
        Console.WriteLine(s.ReverseString());

        Console.WriteLine("\nGeben Sie ein Wort ein: ");
        s = Console.ReadLine();
        Console.WriteLine(s.IsPalindrome());
    }
}