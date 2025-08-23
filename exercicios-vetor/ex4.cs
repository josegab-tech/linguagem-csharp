using System;
using MinhaBiblioteca;

//Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
//vetor.
class ex4
{

    static void Main()
    {   

        Console.WriteLine("Digite o tamanho do vetor real:");
        int tamanhoVetor = int.Parse(Console.ReadLine());

        double[] vetor = new double[tamanhoVetor];

        vetor = new double[tamanhoVetor];
        Biblioteca.gerarVetorReal(vetor);
        Biblioteca.maiorValorReal(vetor);
        Biblioteca.mostrarVetorReal(vetor);


        
    }
}