using System;
using Matriz;
class ex1
{


    

    static void Main()
    {

        int[,] matriz = BiMatriz.gerarMatriz();
        
        BiMatriz.mostrarMatriz(matriz);

        
         int menorValor = BiMatriz.menorValorMatriz(matriz);
       
        Console.WriteLine($"\nO menor valor da matriz é: {menorValor}");
    }
}