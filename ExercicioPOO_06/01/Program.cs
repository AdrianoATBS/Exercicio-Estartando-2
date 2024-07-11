using System;

namespace _01
{
    class Progamn
    {
        static void Main()
        {
            Produto produto = new Produto("Leite", 3.00m, 10);

            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Quantidade em Estoque: {produto.QuantidadeEstoque}");

            int quantidadeAdicionada = produto.AdicionarEstoque(5);
            Console.WriteLine($"\nQuantidade em Estoque após adicionar {quantidadeAdicionada}");
            Console.WriteLine($"Quantidade em Estoque após ser adicionado: {produto.QuantidadeEstoque}");
            

            int quantidadeRemovida = produto.RemoverEstoque(3);
            Console.WriteLine($"\nQuantidade removida do estoque: {quantidadeRemovida}");
            Console.WriteLine($"Quantidade em Estoque após remover: {produto.QuantidadeEstoque}");
            

        }      
    }
}