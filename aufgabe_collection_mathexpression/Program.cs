using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool klammerGefunden = false;
        
        Console.WriteLine("Geben Sie einen mathematischen Ausdruck ein: ");
        string mathExpression = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(mathExpression))
        {
            Console.WriteLine("Keine Eingabe erkannt!");
            return;
        }
        
        Stack<char> stack = new Stack<char>();

        foreach (char c in mathExpression)
        {
            if (c == '(' || c == ')')
            {
                klammerGefunden = true;
            }
            
            if (c == '(') 
                stack.Push(c);
            
            else if (c == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }

                else
                {
                    Console.WriteLine("\nFehler: Zu viele schließende Klammern oder falsche Reihenfolge!");
                    return;
                }
            }
        }
        
                
        if (stack.Count == 0 && klammerGefunden) 
        {
            Console.WriteLine("\nKorrekt geklammert.");
        }
        else if (!klammerGefunden)
        {
            Console.WriteLine("\nDer Ausdruck enthält gar keine Klammern.");
        }
        else
        {
            Console.WriteLine("\nFehler: Es wurden nicht alle Klammern geschlossen.");
        }
    }
}