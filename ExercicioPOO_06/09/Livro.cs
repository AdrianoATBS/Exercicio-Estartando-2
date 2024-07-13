/*
9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o
encapsulamento para garantir que o título e o autor não sejam vazios.
*/

using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Livro
    {
        public string Titulo{ get; private set; }

        public string Autor{ get; private set; }


        public Livro(string titulo, string autor)
        {
            Titulo = string.IsNullOrWhiteSpace(titulo) ? throw new ArgumentException("Não pode ser vazio") : titulo;

            Autor = string.IsNullOrWhiteSpace(autor) ? throw new ArgumentException("Não pode ser vazio") : autor;
        }

        public  void Mensagem()
        {
            Console.WriteLine($"Titulo do Livro {Titulo} - Autor: {Autor}");
        }
    }
}