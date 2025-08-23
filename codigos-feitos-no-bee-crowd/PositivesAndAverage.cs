using System;

class PositivesAndAverage
{

    static void Main()
    {

        float num, soma , positivo;

        positivo = 0;
        soma = 0;
        for (int n = 0; n < 6; n++)
        {
            Console.WriteLine("Digite os valores");
            num = float.Parse(Console.ReadLine());
            if (num > 0)
            {
                positivo++;
                soma += num;
            }
        }

        Console.WriteLine($"{positivo} valores positivos");
        Console.WriteLine($"{(soma / positivo):F1}");
    }
}