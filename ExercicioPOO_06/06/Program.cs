using System;

namespace Produto2
{
      class Program
    {
        static void Main(string[] args)
        {
            GerenciadorProdutos gerenciador = new GerenciadorProdutos();

            while (true)
            {   
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Consultar Produto pelo Código");
                Console.WriteLine("3. Mostrar todos os Produtos");
                Console.WriteLine("4. Sair");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 4)
                    break;

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o preço do produto: ");
                        decimal preco = decimal.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade em estoque: ");
                        int quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Digite o código do produto: ");
                        int codigo = int.Parse(Console.ReadLine());
                        gerenciador.AdicionarProduto(nome, preco, quantidade, codigo);
                        break;
                    case 2:
                        Console.Write("Digite o código do produto a ser consultado: ");
                        int codigoConsulta = int.Parse(Console.ReadLine());
                        Produto produtoConsultado = gerenciador.ConsultarProdutoPeloCodigo(codigoConsulta);
                        if (produtoConsultado != null)
                        {
                            Console.WriteLine(produtoConsultado);
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de Produtos:");
                        gerenciador.ApresentarProdutos();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}   

