namespace aufgabe_tasks_unabhaengigetasks;

class Program
{
    static void Main(string[] args)
    {
        string[] dateien = Directory.GetFiles(".", "*.txt");
        
        // Liste zum Speichern aller gestarteten Tasks
        List<Task> tasks = new List<Task>();

        foreach (var datei in dateien)
        {
            // Startet für jede Datei einen eigenen Task
            Task task = Task.Run(() =>
            {
                CharacterCounter cc1 = new CharacterCounter();
                cc1.BerechneBuchstabenHaeufigkeit(datei);
            });
            
            // Fügt gestarteten Task zur Liste hinzu
            tasks.Add(task);
        }
        
        // Warten, bis alle Tasks abgeschlossen sind
        Task.WaitAll(tasks);
    }
}