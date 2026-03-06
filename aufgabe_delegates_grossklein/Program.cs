namespace aufgabe_delegates_grossklein;

delegate void CharacterHandler(string s);

class Program
{
    static void Main(string[] args)
    {
        Character c = new Character();

        Console.WriteLine("===== UPPERCASE =====");
        CharacterHandler handler = c.UpperCase;
        handler("Hello World");

        Console.WriteLine("\n===== LOWERCASE =====");
        CharacterHandler handler2 = c.LowerCase;
        handler2("Hello World");

        Console.WriteLine("\n===== UPPERLOWER =====");
        CharacterHandler handler3 = c.UpperLower;
        handler3("Hello World");

        Console.WriteLine("\n===== MULTICAST =====");
        CharacterHandler multicast = handler + handler2 + handler3;
        multicast("Hello World");

        Console.WriteLine("\n===== GETINVOCATIONLIST | METHOD | TARGET =====");
        Delegate[] liste = multicast.GetInvocationList();
        Console.WriteLine(liste[0].Method);
        Console.WriteLine(liste[1].Method);
        Console.WriteLine(liste[2].Method.Name);
        Console.WriteLine(liste[2].Target);

        Console.WriteLine("\n===== ANONYME METHODE =====");
        CharacterHandler anonym = delegate(string s)
        {
            string reverse = new string(s.Reverse().ToArray());
            Console.WriteLine(reverse);
        };
        
        anonym("Hello World");
    }
}