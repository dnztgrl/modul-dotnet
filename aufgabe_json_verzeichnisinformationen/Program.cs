using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.IO;
using System.Linq;

namespace aufgabe_json_verzeichnisinformationen;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/Users/deniztugrul";
        List<string> subfolders = new List<string>(Directory.GetDirectories(path));
        List<FolderInfo> folders = new List<FolderInfo>();

        // Optionen für die JSON-Serialisierung
        // WriteIndented sorgt für schön formatiertes JSON
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
            
        foreach (string folder in subfolders)
        {
            try
            {
                int numberOfFiles;

                try
                {
                    numberOfFiles = Directory.EnumerateFiles(folder).Count();
                }
                catch
                {
                    // Wenn der Ordner wegen fehlender Berechtigungen nicht gelesen werden kann
                    // wird die Anzahl der Dateien auf 0 gesetzt
                    numberOfFiles = 0;
                }

                FolderInfo info = new FolderInfo()
                {
                    FolderName = Path.GetFileName(folder),
                    DateOfCreation = Directory.GetCreationTime(folder),
                    NumberOfFiles = numberOfFiles,
                };

                folders.Add(info);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler bei Ordner: {folder}: {ex.Message}");
            }
        }
        
        string json = JsonSerializer.Serialize(folders, options);
        File.WriteAllText("folders.json", json);
        
        string jsonFromFile = File.ReadAllText("folders.json");
        List<FolderInfo> outputFolders = JsonSerializer.Deserialize<List<FolderInfo>>(jsonFromFile);
        foreach (FolderInfo folder in outputFolders)
        {
            Console.WriteLine(folder.ToString());
        }
    }
}