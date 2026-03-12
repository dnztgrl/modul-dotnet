namespace aufgabe_json_verzeichnisinformationen;

public class FolderInfo
{
    public string FolderName { get; set; }
    public DateTime DateOfCreation { get; set; }
    public int NumberOfFiles { get; set; }

    public override string ToString()
    {
        return $"Ordner: {FolderName} | Angelegt: {DateOfCreation:dd.MM.yyyy} | Anzahl Dateien: {NumberOfFiles}";
    }
}