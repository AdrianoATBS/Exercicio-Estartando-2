/*
6 - Utilize o exercício 1 para criar uma lista de produtos e faça métodos para apresentar na
tela e para consultar produtos pelo código.
*/

using System;
using System.Collections.Generic;

namespace Produto2
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int Codigo { get; set; }

        public Produto(string nome, decimal preco, int quantidade, int codigo)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidade;
            Codigo = codigo;
        }

        public int AdicionarEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade não pode ser negativa");
            }
            QuantidadeEstoque += quantidade;
            return quantidade;
        }

        public int RemoverEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade não pode ser negativa");
            }
            if (quantidade > QuantidadeEstoque)
            {
                throw new InvalidOperationException("Quantidade em estoque insuficiente");
            }
            QuantidadeEstoque -= quantidade;
            return quantidade;
        }

        public void Mensagem()
        {
            Console.WriteLine($"Código: {Codigo}, Produto: {Nome}, Preço: {Preco}, Quantidade em estoque: {QuantidadeEstoque}");
        }

        public override string ToString()
        {
            return $"Código: {Codigo}, Produto: {Nome}, Preço: {Preco:C}, Quantidade em Estoque: {QuantidadeEstoque}";
        }
    }

    class GerenciadorProdutos
    {
        private List<Produto> produtos;

        public GerenciadorProdutos()
        {
            produtos = new List<Produto>();
        }

        public void AdicionarProduto(string nome, decimal preco, int quantidade, int codigo)
        {
            var novoProduto = new Produto(nome, preco, quantidade, codigo);
            produtos.Add(novoProduto);
        }

        public void ApresentarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        public Produto ConsultarProdutoPeloCodigo(int codigo)
        {
            return produtos.Find(p => p.Codigo == codigo);
        }
    }
}
