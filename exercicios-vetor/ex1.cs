using System;

class ex1
{

    static double somaVetor(int[] vetor)
    {
        double soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma;
    }

    static void gerarValorVetor(int[] vetor)
    {
        Random aleatorio = new Random();
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(1, 100);
        }
    }

    static int[] gerarTamanhoVetor()
    {
        Console.WriteLine("\nDigite o tamanho do vetor");
        int tamanho = int.Parse(Console.ReadLine());

        return new int[tamanho];
    }
    static void Main()
    {
        int[] vetor = gerarTamanhoVetor();

        gerarValorVetor(vetor);

        double soma = somaVetor(vetor);

        Console.WriteLine("Valores do vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Vetor[{i}] {vetor[i]}");
        }

        Console.WriteLine($"Soma dos valores: {soma}");
        
    }
}