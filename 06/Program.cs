// Exercício64---------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        int[] vetor = null;

        int opcao;

        do
        {
            Console.WriteLine("Escolha uma Opção: ");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares do vetor");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o tamanho do vetor: ");
                    int tamanho = int.Parse(Console.ReadLine());
                    vetor = new int[tamanho];  
                    for (int i = 0; i < tamanho; i++)
                    {
                        Console.WriteLine($"Digite o valor para a posição {i}: ");
                        vetor[i] = int.Parse(Console.ReadLine());
                    }              
                    Console.WriteLine("Vetor carregado com sucesso.");
                    break;

                case 2:
                    if(vetor == null)
                    {
                        Console.WriteLine("Vetor não carregado.");
                    }
                    else
                    {
                        Console.WriteLine("Valores do vetor: ");
                        foreach (var numero in vetor)
                        {
                            Console.WriteLine(numero + " ");
                        }
                    }
                    break;
                
                case 3:
                    if(vetor == null)
                    {
                        Console.WriteLine("Vetor não carregado.");
                    }
                    else
                    {
                        Console.WriteLine("Números pares do vetor: ");
                        foreach(var numero in vetor)
                        {
                            if(numero % 2 == 0)
                            {
                                Console.WriteLine(numero + " ");
                            }
                        }
                    }
                    break;

                case 4:
                    if(vetor == null)
                    {
                        Console.WriteLine("Vetor não carregado.");
                    }
                    else
                    {
                        Console.WriteLine("Números impares do vetor: ");
                        foreach (var numero in vetor)
                        {
                            if(numero % 2 != 0)
                            {
                                Console.WriteLine(numero + " ");
                            }
                        }
                    }
                    break;

                case 5:
                    if(vetor == null)
                    {
                        Console.WriteLine("Vetor não carregado.");
                    }
                    else
                    {
                        int contarParesImpares = 0;
                        for(int i = 1; i < vetor.Length; i = i + 2)
                        {
                            if(vetor[i] % 2 == 0)
                            {
                                contarParesImpares++;
                            }
                        }
                        Console.WriteLine($"Quantidade números pares nos vetores impares: {contarParesImpares}");
                    }
                    break;

                case 6:
                    if(vetor == null)
                    {
                        Console.WriteLine("Vetor não carregado.");
                    }
                    else
                    {
                        int contarImparesPares = 0;
                        for (int i = 0; i < vetor.Length; i = i+ 2)
                        {
                            if(vetor[i] % 2 != 0)
                            {
                                contarImparesPares++;
                            }
                        }
                        Console.WriteLine($"Quantidade números Impares nos vetores pares :{contarImparesPares}");
                    }
                    break;
                
                case 7:
                    Console.WriteLine("Progama Encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção Inválida.");
                    break;          
            }   
        }while (opcao != 7);
    }
}