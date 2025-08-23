using System;

class Average1
{
    static void Main()
    {

        double a, b, media;

        Console.WriteLine("Digite as duas notas:");
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        media = (3.5 * a + 7.5 * b) / 11;

        Console.WriteLine($"MEDIA = {media:F5}");
    }
}