using System;
using MinhaBiblioteca;
// josé Gabriel T1
class exercicio1{
	
	static int passosAoMineral(int[,] matriz){
		
		int linhas, cols, passos;
		passos = 0;
		
		linhas = matriz.GetLength(0);
		cols = matriz.GetLength(1);
		
		for(int i = 0; i< linhas; i++){
			for(int j = 0; j< cols; j++){
				Console.WriteLine($"Analizando posição [{i},{j}]");
				
				if( matriz[i,j] == 2){
					Console.WriteLine($"Indício encontrado na posição [{i},{j}], descendo para o sul");
					i++;
					
				}
				if(matriz[i,j] == 5){
					Console.WriteLine($"Amostra rara encontrada na posição [{i},{j}]");
					i = linhas; j = cols;
					
				}
				passos++;
			}
			
		}
		
		
		
		
		return  passos; //retornar a quantidade de passos
	}
	
	
	
	static void Main(){
		
		int[,] terreno;
		terreno = new int[5,5];
		int passos;
		
		Biblioteca.carregarArquivo(terreno , "mapa.txt");
		Biblioteca.mostrarMatriz(terreno);
		passos = passosAoMineral(terreno);
		Console.WriteLine($"Total de passos {passos}");
		
		
		
		
	}
}