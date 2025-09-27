using System;

class LowerNumber
{

    static void Main()
    {

        /*Escreva um programa que leia um número N. Este N é o tamanho de um array X[N]. Em seguida, leia cada um dos números de X, encontre o menor elemento deste array e sua posição dentro do array, imprimindo esta informação.

Entrada
A primeira linha da entrada contém um inteiro N (1 < N < 1000), indicando o número de elementos que devem ser lidos para um array X[N] de números inteiros. A segunda linha contém cada um dos N valores, separados por um espaço. Lembre-se de que nenhuma entrada terá números repetidos.

Saída
A primeira linha exibe a mensagem “Menor valor:” seguida de um espaço e o menor número lido na entrada. A segunda linha exibe a mensagem “Posicao:” seguida de um espaço e a posição do array em que o menor número está, lembrando que o array começa na posição zero.*/

        int n, menorValor, posicao;


        //Console.WriteLine("Digite o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];


        //Console.WriteLine("digite os valores separando por espaço: ");
        string[] cadeia = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(cadeia[i]); // convertendo a string
        }

        menorValor = vetor[0];
        posicao = 0;

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] < menorValor)
            {
                menorValor = vetor[i];
                posicao = i;
            }
        }

        Console.WriteLine("Menor valor: " + menorValor);
        Console.WriteLine("Posicao: " + posicao);

    }
}