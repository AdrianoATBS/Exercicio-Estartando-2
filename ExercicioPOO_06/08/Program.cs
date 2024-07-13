using System;
using System.Collections.Generic;

namespace Fabricas
{   class Program
    {
        static void Main(string[] args)
        {
            // Criando um fabricante
            Fabricante fabricante = new Fabricante("Fabricante A", "Rua Exemplo, 123", "Cidade Exemplo");
            fabricante.Mensagem();

            // Criando um produto
            Produto produto = new Produto("Produto A", fabricante, 29.99);
            produto.Mensagem();
        }
    }
}