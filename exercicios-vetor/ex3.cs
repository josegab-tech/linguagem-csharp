using System;
using MinhaBiblioteca;

class ex3
{

    static void Main()
    {
        double[] vetor;

        Console.WriteLine("Quantos elementos reais tem o seu vetor?");

        int tamanhoVetor = int.Parse(Console.ReadLine());

        vetor = new double[tamanhoVetor];
        Biblioteca.gerarVetorReal(vetor);
        Biblioteca.mostrarVetorReal(vetor);
        Biblioteca.menorValorReal(vetor);
            




    }
}