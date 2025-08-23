using System;

class soma2valores
{
    static void Main()
    {
        double numero1, numero2, soma;

        Console.WriteLine("Escreva 2 números!");
        numero1 = double.Parse(Console.ReadLine());
        numero2 = double.Parse(Console.ReadLine());

        soma = numero1 + numero2;
        Console.WriteLine($"X = {soma}" );
    }

}