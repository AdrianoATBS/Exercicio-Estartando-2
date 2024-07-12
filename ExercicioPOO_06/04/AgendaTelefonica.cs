/*
Crie uma classe AgendaTelefônica com atributos para armazenar contatos (nome,
telefone, e-mail). Implemente um construtor e métodos para adicionar numa lista, remover
e buscar contatos.
*/

using System;
using System.Collections.Generic;

namespace AgendaTelefonica
{
    class Telefone
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public int Numero{ get; set; }

        public Telefone(string nome, string email, int numero)
        {
            Nome = nome;
            Email = email;
            Numero = numero;
        }

        public void Mensagem()
        {
            Console.WriteLine($"Nome: {Nome}, E-mail: {Email}, Telefone: {Numero}");

        }
    }
    class  Contatos
    {
        private List<Telefone> telefoneList;

        public Contatos()
        {
            telefoneList = new List<Telefone>();
        }

        public void AdicionarContato(string nome, string email, int telefone)
        {
            var novoContato = new Telefone(nome, email, telefone);
            telefoneList.Add(novoContato);
        }
        
        public void RemoverContato(string nome)
        {
            var contato = telefoneList.Find(t => t.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if(contato != null)
            {
                telefoneList.Remove(contato);
                Console.WriteLine($"Contato {nome} removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Contato não encontrado");
            }
        }

        public void BuscarContatos()
        {
            if(telefoneList.Count == 0)
            {
                Console.WriteLine("Nenhum Telefone encontrado");

            }
            else
            {
                foreach(var telefone in telefoneList)
                {
                    telefone.Mensagem();
                }
            }
        }        
        public void Menu()
        {
             while (true)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Remover Contato");
                Console.WriteLine("3 - Buscar Contatos");
                Console.WriteLine("4 - Sair");

                string opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("E-mail: ");
                        string email = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Telefone: ");
                        int telefone;
                        while(!int.TryParse(Console.ReadLine(), out telefone))
                        {
                            Console.WriteLine("Telefone Inválido.");
                        }
                        AdicionarContato(nome, email, telefone);
                        break;
                    
                    case "2":
                        Console.WriteLine("Nome do Contato a remover: ");

                        string nomeRemover = Console.ReadLine()?? string.Empty;
                        RemoverContato(nomeRemover);
                        break;

                    case "3":
                        BuscarContatos();
                        break;
                    
                    case "4":
                        return;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }    
            }
       }


    }
}