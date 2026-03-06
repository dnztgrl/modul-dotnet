namespace aufgabe_delegates_grossklein;

public class Character
{
    public void UpperCase(string s)
    {
        Console.WriteLine(s.ToUpper());
    }

    public void LowerCase(string s)
    {
        Console.WriteLine(s.ToLower());
    }

    public void UpperLower(string s)
    {
        Console.WriteLine(s);
    }
}