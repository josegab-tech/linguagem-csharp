using System;

class AreaOfaCircle
{
    static void Main()
    {

        double pi, raio, area;

        Console.WriteLine("Qual o raio do círculo?");

        raio = double.Parse(Console.ReadLine());
        pi = 3.14159;

        raio = raio * raio;
        area = pi * raio;

        Console.WriteLine($"A={area:F4}");

    }
}