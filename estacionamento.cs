using System;
using System.Collections.Generic;

class Program
{
    const int LimiteVagas = 1; 
    static Dictionary<string, string> veiculos = new Dictionary<string, string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("\n1. Adicionar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: \n");
            Console.WriteLine("==============================================================");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    AdicionarVeiculo();
                    break;
                case "2":
                    RemoverVeiculo();
                    break;
                case "3":
                    ListarVeiculos();
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa. Obrigado!");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarVeiculo()
    {
        if (veiculos.Count >= LimiteVagas)
        {
            Console.WriteLine("O estacionamento atingiu o limite de vagas disponíveis.");
            Console.WriteLine("==============================================================");
            return;
        }

        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        if (!VeiculoExiste(placa))
        {
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();

            veiculos.Add(placa, modelo);
            Console.WriteLine("==============================================================");
            Console.WriteLine("Veículo adicionado com sucesso!");
            Console.WriteLine("==============================================================");
        }
        else
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Veículo com esta placa já está estacionado.");
            Console.WriteLine("==============================================================");
        }
    }

    static void RemoverVeiculo()
    {
        Console.Write("Digite a placa do veículo a ser removido: ");
        string placa = Console.ReadLine();

        if (veiculos.Remove(placa))
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Veículo removido com sucesso.");
            Console.WriteLine("==============================================================");
        }
        else
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Veículo não encontrado no estacionamento.");
            Console.WriteLine("==============================================================");
        }
    }

    static void ListarVeiculos()
    {
        Console.WriteLine("==============================================================");
        Console.WriteLine("Lista de veículos no estacionamento:");
        Console.WriteLine("==============================================================");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Key}, Modelo: {veiculo.Value}");
        }
    }

    static bool VeiculoExiste(string placa)
    {
        return veiculos.ContainsKey(placa);
    }
}

