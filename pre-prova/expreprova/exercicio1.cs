using System;
using System.Reflection.Metadata;
using MinhaBiblioteca;
//t2 josé gabriel
class exercicio1
{
    static bool lerD(string sequencia)
    {
        for (int i = 0; i < sequencia.Length - 2; i++){
            if (sequencia[i] == 'T' && sequencia[i + 1] == 'A' && sequencia[i + 2] == 'A'){
                return true;
            }
        }
        return false;
    }

    static void Main()
    {

        string sequencia;

        Console.WriteLine("Insira o DNA:");
        sequencia = Console.ReadLine().ToUpper();




        bool contem = lerD(sequencia);

        if(contem){
            Console.WriteLine("A sequência contém o stop codon 'TAA'");
        }
        else{
            Console.WriteLine("A sequência NÃO contém o stop codon 'TAA'");
        }

    }
}
