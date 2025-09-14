using System;
using Matriz;
class ex1
{


    static int menorValorMatriz(int[,] matrizRecebida)
    {
        int linhas = matrizRecebida.GetLength(0);
        int colunas = matrizRecebida.GetLength(1);
        int menorValor = matrizRecebida[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matrizRecebida[i, j]< menorValor  )
                {
                    menorValor = matrizRecebida[i,j];
                }
            }
        }
        return menorValor;
 }

    static void Main()
    {

        int[,] matriz = BiMatriz.gerarMatriz();
        
        BiMatriz.mostrarMatriz(matriz);

        
         int menorValor = menorValorMatriz(matriz);
       
        Console.WriteLine($"O menor valor da matriz é: {menorValor}");
    }
}