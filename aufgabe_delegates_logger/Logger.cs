namespace aufgabe_delegates_logger;

public class Logger
{
    private string _file;
    private StreamWriter _writer;

    // Öffnet die Log-Datei zum Anhängen - true = nicht überschreiben
    public Logger(string file)
    {
        _file = file;
        _writer = new StreamWriter(_file, true);
    }

    public void Write(string text)
    {
        _writer.WriteLine(text);
    }

    public void Close()
    {
        _writer.Close();
    }
}