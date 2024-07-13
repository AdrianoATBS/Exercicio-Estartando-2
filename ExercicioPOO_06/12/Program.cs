using System;
using System.Collections.Generic;

namespace AgendaPessoal
{
     class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            while (true)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Remover Contato");
                Console.WriteLine("3 - Buscar Contatos");
                Console.WriteLine("4 - Imprimir Agenda");
                Console.WriteLine("5 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Idade: ");
                        int idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Altura: ");
                        float altura;
                        while (!float.TryParse(Console.ReadLine(), out altura))
                        {
                            Console.WriteLine("Altura inválida.");
                        }
                        agenda.AdicionarContato(nome, idade, altura);
                        break;

                    case "2":
                        Console.WriteLine("Nome do Contato a remover: ");
                        string nomeRemover = Console.ReadLine() ?? string.Empty;
                        agenda.RemoverPessoa(nomeRemover);
                        break;

                    case "3":
                        agenda.BuscarContatos();
                        break;

                    case "4":
                        agenda.BuscarContatos();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}