using System;
using System.IO;
using System.Net;
using System.Threading;

public class DnsResolver
{
    public void ResolveDns(string path)
    {
        Thread.Sleep(500);

        string[] lines = File.ReadAllLines(path);
        string resolvedPath = Path.ChangeExtension(path, ".resolved");

        using (StreamWriter sw = new StreamWriter(resolvedPath))
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string currentFqdn = lines[i];
                try
                {
                    IPAddress[] addresses = Dns.GetHostAddresses(currentFqdn);

                    foreach (IPAddress ip in addresses)
                    {
                        sw.WriteLine($"{currentFqdn} | {ip}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Fehler bei {currentFqdn}: {e.Message}");
                    sw.WriteLine($"{currentFqdn} | FEHLER: Konnte nicht aufgelöst werden");
                }
            }
        }
    }
}