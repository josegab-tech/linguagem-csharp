using System;
using MinhaBiblioteca;
 //t2 josé gabriel
class exercicio2{
	
	
	
	static void Main(){
		
	int[,] matrizAntiga;
	int[,] matrizAtual;
	int linhas,cols;
	int ocupacaoAntiga, ocupacaoAtual;
	ocupacaoAntiga=0;
	ocupacaoAtual=0;
	
	
	Console.WriteLine("digite as linhas e colunas: ");
	linhas = int.Parse(Console.ReadLine());
	cols = int.Parse(Console.ReadLine());
	
	matrizAntiga = new int[linhas,cols];
	matrizAtual = new int[linhas,cols];
	
	Biblioteca.gerarMatriz(matrizAntiga);
	Biblioteca.mostrarMatriz(matrizAntiga);
	
	Biblioteca.gerarMatriz(matrizAtual);
	Biblioteca.mostrarMatriz(matrizAtual);

	for (int i = 0; i < linhas; i++){
			for (int j = 0; j < cols; j++){
				if (matrizAntiga[i, j] == 0){
					ocupacaoAntiga++;
				}
			}
		}
	
	for(int i = 0; i < linhas; i++){
            for(int j = 0; j < cols; j++){
                if(matrizAtual[i, j] != 0){
                    ocupacaoAtual++;
                }
            }
        }

		int tot = linhas * cols;

		Console.WriteLine($"Area ocupação Anterior X Atual {ocupacaoAntiga} X {ocupacaoAtual}");

		double percentualAnt = ((double)ocupacaoAntiga / tot) * 100;
		
		double percentualAtu = ((double)ocupacaoAtual / tot) * 100;

		
	Console.WriteLine($"Houve um aumento de {percentualAtu-percentualAnt:F2} por cento na ocupação");
}
}

	
	