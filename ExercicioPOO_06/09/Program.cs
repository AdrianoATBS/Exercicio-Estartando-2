using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livroNovo = new Livro("Arquitetura Limpa: o Guia do Artesão Para Estrutura e Design de Software", "Robert C. Martin (Autor), Kevlin Henney (Prefácio), Jason Gorman (Epílogo)");
            livroNovo.Mensagem();

        }
    }
}
