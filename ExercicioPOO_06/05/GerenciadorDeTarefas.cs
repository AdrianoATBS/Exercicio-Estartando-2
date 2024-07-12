/*
- Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de
tarefas (descrição, data de vencimento). Implemente um construtor e métodos para
adicionar, remover e listar tarefas. Adicione um método para verificar se a tarefa deverá
ser executada no dia de hoje.
*/
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Lista
    {   
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }

        public Lista(string nome, string descricao, DateTime vencimento)
        {
            Nome = nome;
            Descricao = descricao;
            Vencimento = vencimento;
        }
        
        public void Mensagem()
        {
            Console.WriteLine($"Produto: {Nome}, Descrição: {Descricao}, Vencimento: {Vencimento:yyyy-MM-dd}");
        }

        public bool VerificarTarefaHoje()
        {
            return Vencimento.Date == DateTime.Today;
        }
    }

    class ListaTarefas
    {
        private List<Lista> lista;

        public ListaTarefas()
        {
            lista = new List<Lista>();
        }

        public void AdicionarLista(string nome, string descricao, DateTime vencimento)
        {
            var novaLista = new Lista(nome, descricao, vencimento);
            lista.Add(novaLista);
        }

        public void RemoverLista(string nome)
        {
            var listaRemovida = lista.Find(l => l.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (listaRemovida != null)
            {
                lista.Remove(listaRemovida);
                Console.WriteLine($"Foi removido da Lista o {nome}");
            }
            else
            {
                Console.WriteLine("Lista não encontrada");
            }
        }

        public void ListarTarefas()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
            else
            {
                foreach (var tarefa in lista)
                {
                    tarefa.Mensagem();
                }
            }
        }

        public void VerificarTarefaHoje()
        {
            bool encontrou = false;
            foreach (var tarefa in lista)
            {
                if (tarefa.VerificarTarefaHoje())
                {
                    tarefa.Mensagem();
                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("Nenhuma tarefa para hoje");
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Escolha uma Opção: ");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Listar Tarefas");
                Console.WriteLine("4 - Verificar Tarefas de Hoje");
                Console.WriteLine("5 - Sair");
                
                string? opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Nome da Tarefa: ");
                        string? nome = Console.ReadLine();

                        Console.WriteLine("Descrição da Tarefa:");
                        string? descricao = Console.ReadLine();

                        Console.WriteLine("Data de Vencimento (yyyy-MM-dd):");
                        DateTime vencimento;
                        while (!DateTime.TryParse(Console.ReadLine(), out vencimento))
                        {
                            Console.WriteLine("Data inválida. Tente novamente (yyyy-MM-dd):");
                        }

                        if (nome != null && descricao != null)
                        {
                            AdicionarLista(nome, descricao, vencimento);
                        }
                        else
                        {
                            Console.WriteLine("Nome ou descrição não podem ser nulos.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Nome da Tarefa para remover: ");
                        string? listaRemover = Console.ReadLine();

                        if (listaRemover != null)
                        {
                            RemoverLista(listaRemover);
                        }
                        else
                        {
                            Console.WriteLine("Nome da tarefa não pode ser nulo.");
                        }
                        break;

                    case "3":
                        ListarTarefas();
                        break;

                    case "4":
                        VerificarTarefaHoje();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            }
        }
    }

}