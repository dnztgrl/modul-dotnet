namespace aufgabe_erweiterungsmethoden_stringextension;

static class StringExtensions
{
    public static int ToInt32(this string s)
    {
        if (s == null)
            throw new ArgumentNullException(nameof(s));
        
        return int.Parse(s);
    }

    public static string ReverseString(this string s)
    {
        if (s == null)
            throw new ArgumentNullException(nameof(s));
        
        string result = String.Empty;

        for (int i = s.Length -1; i >= 0; i--)
        {
            result += s[i];
        }

        return result;
    }

    public static bool IsPalindrome(this string s)
    {
        if (s == null)
            throw new ArgumentNullException(nameof(s));

        string lower = s.ToLower();
        return lower == lower.ReverseString();
    }
}