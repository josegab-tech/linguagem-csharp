using System;
using Matriz;
class ex2
{
    static void Main()
    {

        int[,] matriz = BiMatriz.gerarMatriz();
        
        BiMatriz.mostrarMatriz(matriz);

        
         int maiorValor = BiMatriz.maiorValorMatriz(matriz);
       
        Console.WriteLine($"\nO maior valor da matriz é: {maiorValor}");
    }
}