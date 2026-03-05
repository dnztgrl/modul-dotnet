namespace aufgabe1;

public class Person
{
    public string Name { get; set; }
    public string Vorname { get; set; }
    private int _alter;

    public int Alter
    {
        get { return _alter; }
        set
        {
            if (value < 0)
            {
                throw new Exception("Kein negatives Alter erlaubt!");
            }

            else
            {
                _alter = value;
            }
        }
    }
}