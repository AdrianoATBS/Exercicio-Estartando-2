/*
Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades
Nome, Endereço e Cidade. Produto que tenha as propriedades Nome, Fabricante (objeto
da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome não
seja vazio e que o preço seja positivo.
*/

using System;

namespace Fabricas
{
    class Fabricante
    {
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Cidade { get; private set; }

        // Construtor
        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = string.IsNullOrWhiteSpace(nome) ? throw new ArgumentException("Nome não pode ser vazio") : nome;
            Endereco = endereco;
            Cidade = cidade;
        }

        // Método para exibir informações do fabricante
        public void Mensagem()
        {
            Console.WriteLine($"Fabricante: {Nome}, Endereço: {Endereco}, Cidade: {Cidade}");
        }
    }

    class Produto
    {
        public string Nome { get; private set; }
        public Fabricante Fabricante { get; private set; }
        public double Preco { get; private set; }

        // Construtor
        public Produto(string nome, Fabricante fabricante, double preco)
        {
            Nome = string.IsNullOrWhiteSpace(nome) ? throw new ArgumentException("Nome não pode ser vazio") : nome;
            Fabricante = fabricante ?? throw new ArgumentNullException(nameof(fabricante), "Fabricante não pode ser vazio");
            Preco = preco <= 0 ? throw new ArgumentException("Preço não pode ser negativo ou zero") : preco;
        }

        // Método para exibir informações do produto
        public void Mensagem()
        {
            Console.WriteLine($"Produto: {Nome}, Fabricante: {Fabricante.Nome}, Preço: {Preco:C}");
        }
    }
}
