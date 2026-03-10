namespace aufgabe_events_beobachteramfluss;

public class Fluss
{
    private string _name;
    private int _wasserstand;

    // Events für die verschiedenen Wasserstände
    public event EventHandler<WasserStandEventArgs> WasserstandUnter250;
    public event EventHandler<WasserStandEventArgs> WasserstandUnter3000;
    public event EventHandler<WasserStandEventArgs> WasserstandUeber8000;
    public event EventHandler<WasserStandEventArgs> WasserstandUeber8200;

    public Fluss(string name)
    {
        _name = name;
    }

    public string Name
    {
        get { return _name; }
    }
    
    public int Wasserstand
    {
        get { return _wasserstand; }
        set
        {
            if (_wasserstand == value)
            {
                return;
            }

            // EventArgs mit neuem Wasserstand erstellen
            WasserStandEventArgs e = new WasserStandEventArgs(value);

            // Events auslösen, wenn Grenzwerte über- oder unterschritten
            if (value < 250)
            {
                WasserstandUnter250?.Invoke(this, e);
            }

            if (value < 3000)
            {
                WasserstandUnter3000?.Invoke(this, e);
            }

            if (value > 8000)
            {
                WasserstandUeber8000?.Invoke(this, e);
            }

            if (value > 8200)
            {
                WasserstandUeber8200?.Invoke(this, e);
            }
            
            // Neuen Wasserstand speichern
            _wasserstand = value;
        }
    }
}