using System;
using MinhaBiblioteca;
// josé Gabriel T1
class exercicio2{
	
	static int dias22(double[] vetor){
		
		int contador = 0;
		for(int i = 0; i< 30; i++){
			if (vetor[i] >= 22 && vetor[i] <=25){
				contador++;
			}
		}
		return contador;
	}
	
	
	static void Main(){
		
		double[] vetor;
		vetor = new double[30];
		double media;
		media=0;
		
		Biblioteca.carregarArquivo(vetor, "temp.txt");
		
		Console.WriteLine("*** Vetor de Temperaturas***");
		
		Biblioteca.mostrarVetor(vetor);
		for(int i = 0; i < 30; i++){
			media += vetor[i];
		}
		media = media/ 30;
		Console.WriteLine($"Média mensal das temperaturas {media:F2}");
		
		if(media > 22){
			Console.WriteLine("Alerta de temperatura média mensal - maior que 22 graus");
			
		}
		
		int tot = dias22(vetor);
		Console.WriteLine($"Total de dias com temperatura entre 22 e 25 graus: {tot}");
		
		//Console.WriteLine($"Média mensal das temperaturas {media}.F2");
		
		
		
	}
}