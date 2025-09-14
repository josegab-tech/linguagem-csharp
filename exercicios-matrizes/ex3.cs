using System;
using Matriz;

class ex3
{

    static void Main()
    {
        int[,] matriz = BiMatriz.gerarMatriz();
        BiMatriz.mostrarMatriz(matriz);

        int quantidadeNumero = BiMatriz.quantidadeValorInteiro(matriz);

        Console.WriteLine($"\nO valor aparece {quantidadeNumero} vezes em sua matriz.");
    }
}