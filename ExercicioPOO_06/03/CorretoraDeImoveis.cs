
/*Crie uma classe CorretoraDeImóveis com atributos para armazenar informações sobre 
imóveis (endereço, preço, tipo). Implemente um construtor e métodos para listar imóveis 
disponíveis e calcular o valor médio. Crie um menu que contenha as opções de inserir 
imoveis, alterar preço do imovel e apresentar todos os imoveis. Insira os imoveis numa 
lista para facilitar o trabalho.
*/
using System;
using System.Collections.Generic;

namespace CorretoraDeImoveis
{
    class Imovel
    {
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public void Mensagem()
        {
            Console.WriteLine($"Endereço: {Endereco}, Preço: R$ {Preco:F2}, Tipo: {Tipo}");
        }
    }

    class Corretora
    {
        private List<Imovel> imoveis;

        public Corretora()
        {
            imoveis = new List<Imovel>();
        }

        public void AdicionarImovel(string endereco, double preco, string tipo)
        {
            var novoImovel = new Imovel(endereco, preco, tipo);
            imoveis.Add(novoImovel);
        }

        public void AlterarPreco(string endereco, double novoPreco)
        {
            foreach (var imovel in imoveis)
            {
                if (imovel.Endereco == endereco)
                {
                    imovel.Preco = novoPreco;
                    Console.WriteLine($"Preço do imóvel em {endereco} alterado para R$ {novoPreco:F2}.");
                    return;
                }
            }
            Console.WriteLine("Imóvel não encontrado.");
        }

        public void ListarImoveis()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel disponível.");
            }
            else
            {
                foreach (var imovel in imoveis)
                {
                    imovel.Mensagem();
                }
            }
        }

        public double CalcularValorMedio()
        {
            if (imoveis.Count == 0) return 0;

            double total = 0;
            foreach (var imovel in imoveis)
            {
                total = total + imovel.Preco;
            }
            return total / imoveis.Count;
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir Imóvel");
                Console.WriteLine("2. Alterar Preço do Imóvel");
                Console.WriteLine("3. Listar Todos os Imóveis");
                Console.WriteLine("4. Calcular Valor Médio dos Imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Endereço: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo: ");
                        string tipo = Console.ReadLine();
                        AdicionarImovel(endereco, preco, tipo);
                        break;

                    case "2":
                        Console.Write("Endereço do imóvel: ");
                        string enderecoAlteracao = Console.ReadLine();
                        Console.Write("Novo Preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        AlterarPreco(enderecoAlteracao, novoPreco);
                        break;

                    case "3":
                        ListarImoveis();
                        break;

                    case "4":
                        double valorMedio = CalcularValorMedio();
                        Console.WriteLine($"Valor Médio dos Imóveis: R$ {valorMedio:F2}");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }
    }
}
