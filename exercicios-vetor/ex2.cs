using System;
using System.Collections.Specialized;
using MinhaBiblioteca;

class ex2
{

    static void Main()
    {
        int[] vetor;
        int tamanhoVetor;
        Console.WriteLine("Qual o tamanho do vetor?");
        tamanhoVetor = int.Parse(Console.ReadLine());

        vetor = new int[tamanhoVetor];
        Biblioteca.gerarVetor(vetor);
        int impar= Biblioteca.contarImpar(vetor);
        Biblioteca.mostrarVetor(vetor);
        Console.WriteLine($"Existem {impar} no vetor");
    }
}

