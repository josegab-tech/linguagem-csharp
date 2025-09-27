using System;

class LineInArray
{


    static void Main()
    {

        int linha, col, especifica;
        soma = 0;
        media = 0;
        double media,soma;
        double[,] matriz;

        linha = 12;
        col = 12;

        matriz = new double[linha, col];


        //Console.WriteLine("Qual a linha que quer analizar?");
        especifica = int.Parse(Console.ReadLine());

        char letra;
        //Console.WriteLine("S ou M?");
        letra = char.Parse(Console.ReadLine().ToUpper());

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < col; j++)
            {
                //Console.WriteLine("Valor:");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < col; j++)
            {
                //Console.Write(matriz[i, j]);

            }
        }

        if (letra == 'S')
        {
                for (int j = 0; j < col; j++)
                {
                    soma += matriz[especifica,j];
                }
            Console.WriteLine(soma.ToString("F1"));
        }
        if (letra == 'M')
        {
                for (int j = 0; j < col; j++)
                {
                    soma += matriz[especifica,j];
                    
                }
            media = soma / col;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}