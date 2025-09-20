using System;
using Matriz;
class ex8
{

    static void Main()
    {
        int quantidadeRaios, x, y, linhas, colunas;


        Console.WriteLine("Qual a quantidade de linhas e colunas do mapa?");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas, colunas];//definindo tamanho matriz

        Console.WriteLine("Qual a quantidade de raios registradas?");
        quantidadeRaios = int.Parse(Console.ReadLine());

        BiMatriz.mostrarMatriz(matriz);

        int contador = 0;
        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.Write("\n Quais cordenadas que o raio caiu:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            matriz[x, y]++;

            if (matriz[x, y] > 1)
            {
                contador++;
            }
        }
        BiMatriz.mostrarMatriz(matriz);

        
            

        Console.WriteLine($"\nCairam {contador} raios no mesmo lugar!!!");
    }
}
