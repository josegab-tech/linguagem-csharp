using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;
namespace CadastroViagem;

// José Gabriel e Tiago lemes

    class Program
    {

    static void consumoGastoTotal(List<Viagem> listaDeViagens)
    {
        double kmRodado, consumoMedio, consumoTotalComb = 0, consumoTotalViagem = 0;

        Console.WriteLine("Qual o preço do litro da gasolina: ");
        double precoGasolina = double.Parse(Console.ReadLine());

        foreach (Viagem v in listaDeViagens)
        {
            kmRodado = v.kmRodados;
            consumoMedio = v.consumoMedio;
            consumoTotalComb += kmRodado / consumoMedio;
            consumoTotalViagem += precoGasolina * consumoTotalComb;
        }
        Console.WriteLine($"Consumo total de combustível: {consumoTotalComb:F2} litros");
        Console.WriteLine($"Gasto total com todas as viagens: R$ {consumoTotalViagem:F2}");
         }
        
        static void consumoTotal(List<Viagem> listadeViagem)
        {
            double kmRodado, consumoMedio, consumoTotalComb, consumoTotalViagem;

            Console.WriteLine("Qual o preço do litro da gasolina: ");
            double precoGasolina = double.Parse(Console.ReadLine());

            foreach (Viagem v in listadeViagem)
            {
                Console.WriteLine
                    ($"Modelo:{v.modeloVeiculo}");
                Console.WriteLine($"Placa:{v.placaVeiculo}");
                Console.WriteLine($"Destino:{v.destino}");
                Console.WriteLine($"Km Rodados:{v.kmRodados}");
                Console.WriteLine($"Consumo Medio:{v.consumoMedio}");

                kmRodado = v.kmRodados;
                consumoMedio = v.consumoMedio;
                consumoTotalComb = kmRodado / consumoMedio;
                Console.WriteLine($"O consumo total de combustível dessa viagem foi de {consumoTotalComb}");
                consumoTotalViagem = precoGasolina * consumoTotalComb;
                Console.WriteLine($"O consumo total da viagem foi de {consumoTotalViagem}\n");

            }
        }
        static bool buscaMaior(List<Viagem> listadeViagem, double kMPedido)
        {
            bool achou;
            achou = false;
            foreach (Viagem v in listadeViagem)
            {
                if (v.consumoMedio < kMPedido)
                {
                    achou = true;

                    Console.WriteLine
                    ($"Modelo:{v.modeloVeiculo}");
                    Console.WriteLine($"Placa:{v.placaVeiculo}");
                    Console.WriteLine($"Destino:{v.destino}");
                    Console.WriteLine($"Km Rodados:{v.kmRodados}");
                    Console.WriteLine($"Consumo Medio:{v.consumoMedio}\n");


                }
            }

            return achou;
        }
        static bool checarPlaca(List<Viagem> listaDeViagens, string placa)
        {
            bool achou = false;
            foreach (Viagem v in listaDeViagens)
            {
                if (placa == v.placaVeiculo)
                {
                    Console.WriteLine("*** Viagenm\n ***");
                    Console.WriteLine($"Modelo:{v.modeloVeiculo}");
                    Console.WriteLine($"Placa:{v.placaVeiculo}");
                    Console.WriteLine($"Destino:{v.destino}");
                    Console.WriteLine($"Km Rodados:{v.kmRodados}");
                    Console.WriteLine($"Consumo Medio:{v.consumoMedio}\n");

                    achou = true;
                }
            }
            return achou;



        }
        
        static void cadastroViagem(List<Viagem> listaDeViagens)
        {
            Viagem novaViagem = new Viagem();
            Console.WriteLine("Entre com o modelo do veículo");
            novaViagem.modeloVeiculo = Console.ReadLine();

            Console.WriteLine("Entre com a placa do veículo");
            novaViagem.placaVeiculo = Console.ReadLine();

            Console.WriteLine("Entre com o destino da viagem");
            novaViagem.destino = Console.ReadLine();

            Console.WriteLine("Entre com a quantidade de km rodados");
            novaViagem.kmRodados = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o consumo médio");
            novaViagem.consumoMedio = double.Parse(Console.ReadLine());

            listaDeViagens.Add(novaViagem);
        }
        static void mostraViagens(List<Viagem> listaDeViagens)
        {
            Console.WriteLine("*** Viagens ***");
            for (int i = 0; i < listaDeViagens.Count; i++)
            {
                Console.WriteLine($"\n**Viagem {i + 1}");
                Console.WriteLine
                    ($"Modelo:{listaDeViagens[i].modeloVeiculo}");
                Console.WriteLine($"Placa:{listaDeViagens[i].placaVeiculo}");
                Console.WriteLine($"Destino:{listaDeViagens[i].destino}");
                Console.WriteLine($"Km Rodados:{listaDeViagens[i].kmRodados}");
                Console.WriteLine($"Consumo Medio:{listaDeViagens[i].consumoMedio}");
            }
        }// fim funcao mostra

        static void salvarDados(List<Viagem> listaDeViagens, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (Viagem viagem in listaDeViagens)
            {
                writer.WriteLine($"{viagem.modeloVeiculo},{viagem.placaVeiculo},{viagem.kmRodados},{viagem.consumoMedio},{viagem.destino}");
            }

            Console.WriteLine("Dados salvos com sucesso!");
            writer.Dispose();
        }

        static void carregarDados(List<Viagem> listaDeViagens, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(',');
                    Viagem viagem = new Viagem();
                    viagem.modeloVeiculo = campos[0];
                    viagem.placaVeiculo = campos[1];
                    viagem.kmRodados = double.Parse(campos[2]);
                    viagem.consumoMedio = double.Parse(campos[3]);
                    viagem.destino = campos[4];
                    listaDeViagens.Add(viagem);
                }
                Console.WriteLine("Dados carregados com sucesso!");
            }
            else
                Console.WriteLine("Arquivo não encontrado :(");

        }

        static int menu()
        {
            Console.WriteLine("*** Sistema de Controle de Viagens ***");
            Console.WriteLine("1 - Inserir Viagem");
            Console.WriteLine("2 - Mostrar Viagens");
            Console.WriteLine("3 - Buscar viagens pela placa");
            Console.WriteLine("4 - Buscar viagens com o maior consumo");
            Console.WriteLine("5 - Consumo total de combustível e viagem");
            Console.WriteLine("6 -Apresentar consumo total de combustível e gasto de todas as viagens");
            Console.WriteLine("0 - Sair");
            int op = int.Parse(Console.ReadLine());
            return op;
        }


        static void Main()
        {
            List<Viagem> listaDeViagens = new List<Viagem>();
            int op;
            carregarDados(listaDeViagens, "viagens.txt");
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        cadastroViagem(listaDeViagens);
                        break;
                    case 2:
                        mostraViagens(listaDeViagens);
                        break;

                    case 3:
                        Console.WriteLine("Digite a placa desejada");
                        string placa = Console.ReadLine();
                        bool achou = checarPlaca(listaDeViagens, placa);
                        if (!achou)
                        {
                            Console.WriteLine("Placa não rodou por ai");
                        }
                        break;
                    case 4:

                        double km;
                        Console.WriteLine("Digite o valor para buscar viagens que consumiram mais");
                        km = double.Parse(Console.ReadLine());

                        achou = buscaMaior(listaDeViagens, km);
                        if (!achou)
                        {
                            Console.WriteLine("não existe viagem com menor consumo");
                        }

                        break;

                    case 5:
                        consumoTotal(listaDeViagens);
                        break;
                    case 6:
                        consumoGastoTotal(listaDeViagens);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        salvarDados(listaDeViagens, "viagens.txt");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (op != 0);


        }
    }