
using System;
using System.Security.Cryptography.X509Certificates;

class ex11
{

    static string decodificar(string fraseCodificada)
    {

        char[] decodificada = new char[fraseCodificada.Length];
        int pos = 0;

        for (int i = 0; i < fraseCodificada.Length; i++)
        {
            if (fraseCodificada[i] != 'p')
            {
                decodificada[pos] = fraseCodificada[i];
                pos++;
                
            }
            else if (i>0 && i < fraseCodificada.Length -1 && fraseCodificada[i - 1] == 'p' && fraseCodificada[i + 1] == 'p') //tratamento com IA
            {
                decodificada[pos] = fraseCodificada[i];
                pos++;

            }
        }
        return new string(decodificada , 0, pos);
    }
    static void Main()
    {

        string mensagem;

        Console.WriteLine("Escreva a mensagem codificada p");
        mensagem = Console.ReadLine();
        Console.WriteLine($"Frase decodificada: {decodificar(mensagem)}");


        Console.ReadKey();
    }
}