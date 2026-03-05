using System;
using aufgabe_binarysearchtree;

class Program
{
    static void Main(string[] args)
    {
        // ARRAY ERSTELLEN
        BinaryTree<int> tree = new BinaryTree<int>();
        
        // ZAHLEN HINZUFÜGEN
        tree.Insert(50);
        tree.Insert(100);
        tree.Insert(25);
        tree.Insert(1);
        tree.Insert(10);
        tree.Insert(75);
        tree.Insert(65);
        tree.Insert(85);
        tree.Insert(61);
        tree.Insert(45);
        tree.Insert(35);
        tree.Insert(15);
        tree.Insert(10);

        Console.WriteLine("\nZahlen in aufsteigender Reihenfolge: ");
        // INORDER AUSGABE
        tree.PrintInorder();
        
        // SEARCH TEST
        Console.WriteLine("\n========== SEARCH ==========");
        BinaryTreeNode<int> search1 = tree.Search(10);
        BinaryTreeNode<int> search2 = tree.Search(78);

        if (search1 == null)
        {
            Console.WriteLine("Wert nicht gefunden");
        }
        else 
            Console.WriteLine(search1.Data);
        
        if (search2 == null)
        {
            Console.WriteLine("Wert nicht gefunden");
        }
        else 
            Console.WriteLine(search2.Data);
        
        // CONTAINS TEST
        Console.WriteLine("\n========== CONTANINS ==========");
        Console.WriteLine(tree.Contains(10) ? "Wert gefunden" : "Wert nicht gefunden");
        Console.WriteLine(tree.Contains(78) ? "Wert gefunden" : "Wert nicht gefunden");
        
        // DELETE TEST
        Console.WriteLine("\n========== DELETE ==========");
        tree.Delete(50);
        tree.Delete(61);
        tree.Delete(62); // WERT EXISTIERT NICHT
        tree.Delete(50); // WERT SCHON GELÖSCHT
        tree.PrintInorder();
        
        // CLEAR TEST
        Console.WriteLine("\n========== TSCHÜSS BAUM ==========");
        tree.Clear();
        tree.PrintInorder();
    }
}