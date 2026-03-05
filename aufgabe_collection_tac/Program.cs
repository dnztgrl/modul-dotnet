using System;
using System.Collections.Generic;
using System.IO;

namespace aufgabe_collection_tac
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string path = @"/Users/deniztugrul/Library/CloudStorage/ProtonDrive-deniztugrul@protonmail.com-folder/ITA3-MeineDateien/07. dotNET/02 - RegEx/Aufgaben/Froschkönig Unix Zeilenumbrüche.txt";

            string[] lines = File.ReadAllLines(path);
            
            foreach (string line in lines)
            {
                stack.Push(line);
            }

            while (stack.Count > 0)
            {
                string line = stack.Pop();
                Console.WriteLine(line);
            }
        }
    }
}