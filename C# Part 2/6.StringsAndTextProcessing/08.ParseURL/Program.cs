using System;

class ParseURL
{
    static void Main()
    {
        string url = Console.ReadLine();

        int index = 0;

        index = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0, index));
        url = url.Remove(0, index + 3);

        index = url.IndexOf('/');
        Console.WriteLine("[server] = {0}", url.Substring(0, index));
        url = url.Remove(0, index);

        Console.WriteLine("[resource] = {0}", url);
    }
}