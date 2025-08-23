using System;
using Microsoft.VisualBasic;

namespace MinhaBiblioteca
{
    public class Biblioteca
    {
        public static void lerVetor(int[] vetor)
        {
            Console.WriteLine("Entre com os dados do vetor:");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Array[{i}]:");
                vetor[i] = int.Parse(Console.ReadLine());
            }// fim for

        }

        public static void gerarVetor(int[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);

        }

        public static void gerarVetorReal(double[] vetor)
        {
            Random aleatorio = new Random();
            for (int i = 0; i < vetor.Length; i++)
                vetor[i] = aleatorio.Next(1, 100);

        }
        public static void mostrarVetor(int[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);
            Console.WriteLine();
        }

        public static void mostrarVetorReal(double[] vetor)
        {
            Console.WriteLine("Dados do Vetor:");
            for (int i = 0; i < vetor.Length; i++)
                Console.Write("|" + vetor[i]);
            Console.WriteLine();
        }


        public static int contarImpar(int[] vetor)
        {
            int impar = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    impar++;
                }
            }
            return impar;
        }

        public static void maiorValorReal(double[] vetor)
        {
            double maiorValor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maiorValor)
                {
                    maiorValor = vetor[i];
                }
            }
            Console.WriteLine($"O maior valor do vetor é: {maiorValor}");
        }
        
        public static void menorValorReal(double[] vetor)
        {   
            double menorValor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < menorValor)
                {
                    menorValor = vetor[i];
                }
            }
            Console.WriteLine($"O menor valor do vetor é: {menorValor}");
        }
        
    }

}