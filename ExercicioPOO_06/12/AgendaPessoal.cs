/*
Crie uma classe Agenda que pode armazenar inúmeras pessoas e que seja capaz de
realizar as seguintes operações:
•void armazenaPessoa(String nome, int idade, float altura);
•void removePessoa(String nome);
•Pessoa buscaPessoa(String nome); retorna a pessoa com o nome informado
•void imprimeAgenda(); imprime os dados de todas as pessoas da agenda
•Faça um menu para navegar entre as opções infinitamente.
*/

using System;
using System.Collections.Generic;

namespace AgendaPessoal
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }

        public Pessoa(string nome, int idade, float altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }

    class Agenda
    {
        private List<Pessoa> contatos = new List<Pessoa>();

        public void AdicionarContato(string nome, int idade, float altura)
        {
            var novoContato = new Pessoa(nome, idade, altura);
            contatos.Add(novoContato);
            Console.WriteLine("Contato adicionado com sucesso.");
        }

        public void RemoverPessoa(string nome)
        {
            var contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Pessoa {nome} não encontrada.");
            }
        }

        public void BuscarContatos()
        {
            Console.WriteLine("Contatos na agenda:");
            foreach (var pessoa in contatos)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }
    }
}