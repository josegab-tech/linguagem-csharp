using System;

namespace Matriz;

public class BiMatriz
{

    public static int[,] gerarMatriz()
    {
        int linhas, colunas;
        Console.WriteLine("Digite o número de linhas:");
        linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas:");
        colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];
        Random random = new Random();

        // Preenche a matriz
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(0, 101);
            }
        }

        return matriz;
    }


    public  static void mostrarMatriz(int[,] matriz)
    {
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"\n{matriz[i, j],3} ");
            }
        }
    }

}