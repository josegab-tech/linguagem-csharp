using System;

namespace Matriz;

public class BiMatriz
{

    //função que gera números aleatórios
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

    //função que mostra a matriz
    public static void mostrarMatriz(int[,] matriz)
    {

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"\n[{i},{j}] {matriz[i, j],3} ");
            }
        }
    }

    //função que pega e mostra o menor valor da matriz
    public static int menorValorMatriz(int[,] matrizRecebida)
    {
        int linhas = matrizRecebida.GetLength(0);
        int colunas = matrizRecebida.GetLength(1);
        int menorValor = matrizRecebida[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matrizRecebida[i, j] < menorValor)
                {
                    menorValor = matrizRecebida[i, j];
                }
            }
        }
        return menorValor;
    }


    //função que pega e mostra o maior valor da matriz
    public static int maiorValorMatriz(int[,] matrizRecebida)
    {
        int linhas = matrizRecebida.GetLength(0);
        int colunas = matrizRecebida.GetLength(1);
        int maiorValor = matrizRecebida[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matrizRecebida[i, j] > maiorValor)
                {
                    maiorValor = matrizRecebida[i, j];
                }
            }
        }
        return maiorValor;
    }


    public static int quantidadeValorInteiro(int[,] matrizRecebida)
    {

        Console.WriteLine("\nDigite um número inteiro que deseja analisar se está em sua matriz: ");
         int numeroDesejado = int.Parse(Console.ReadLine());
         int quantidadeNumeroDesejado = 0;

        int linhas = matrizRecebida.GetLength(0);
        int colunas = matrizRecebida.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matrizRecebida[i, j] == numeroDesejado)
                {
                    quantidadeNumeroDesejado++;
                }
            }
        }
        return quantidadeNumeroDesejado;
    }
}

 