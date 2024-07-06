 //Exercício 26-----------------------------------------------

//  using System;
//  internal class Program
//  {
//      static void Main()
//      {
//         int num = 100;
//         while ( num >= 1)
//         {
//             Console.WriteLine(num);
//             num--;
//         }
       

//      }
//  }

 // Exercício 27----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//       Console.WriteLine("Digite a quantidade de números: ");
//       int quantidade = int.Parse(Console.ReadLine());

//       for (int i = 0; i < quantidade; i++)
//       {
//         Console.WriteLine($"Digite o número {i + 1}");
//         int numero = int.Parse(Console.ReadLine());

//         long fatorial = 1;

//         for(int a = 1; a <= numero; a++)
//         {
//         fatorial = fatorial * a;
//         }
//         Console.WriteLine($"O fatorial de {numero} é {fatorial}");
//       }
//     }
// }


// Exercício 28-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         for(int i = 100; i<= 200; i++)
//         {
//             if(i % 2 != 0)
//             {
//                 Console.WriteLine($"Os Números impares entre 100 e 200 são: {i}");
//             }
//         }
        
//     }
// }

// Exercício 29-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         for (int i = 2000; i >= 1; i--)
//         {
//             Console.WriteLine($"Número: {i}");

//         }
        
//     }
// }

// Exercício 30-----------------------------------------------


// using System;
// using System.Threading;


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Digite um número da tabuada: ");
//         int numero = int.Parse(Console.ReadLine());

//         Console.WriteLine($"Tabuada do {numero}");
//         for (int i = 1; i < 11; i++)
//         {
//             int resultado = numero * i;
//             Thread.Sleep(1500);
//             Console.WriteLine($"Número escolhido: {numero} x {i} = {resultado}");
//         }
//     }
// }

// Exercício 31-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {      
//        int numero;
//        int par = 0;
//        int impar = 0;

//         Console.WriteLine("Digite um número positivo(+) ou um número negativo(-) para sair");
        
//         while(true)
//         {   
//             try
//             {
//             numero = int.Parse(Console.ReadLine());

//             if(numero < 0)
//             {
//                 Console.WriteLine("Você encerrou o código");
//                 break;
//             }
//             else if(numero % 2 == 0)
//             {
//                 Console.WriteLine($"O {numero} é par");
//                 par = par + numero;
                
//             }
//             else
//             {
//                 Console.WriteLine($"O {numero} é impar");
//                 impar = impar + numero;
               
//             }
//             }
//             catch(Exception exception)
//             {
//                 Console.WriteLine($"Ocorreu um erro: {exception.Message}");
//                 //Console.WriteLine($"{exception.StackTrace}");
//                 Console.WriteLine("Informe um número válido!");
//             }
//         }
//         Console.WriteLine($"A soma dos números pares é {par}");

//         Console.WriteLine($"A soma dos números impares é {impar} ");
           
//     }

// }

// Exercício 32-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             int numero;

//             do
//             {
//                 Console.WriteLine("Digite um número maior que 0 e menor que 10: ");
//                 numero = int.Parse(Console.ReadLine());
//             }while(numero <= 0 || numero >= 10);

//             int soma = 0;
//             int contador = 0;

//             if (numero % 2 == 0)
//             {
//                 numero = numero + 1;
//             }

//             for (int i =0; i < 20;i++)
//             {
//                 soma = soma + numero * numero;
//                 numero = + numero + 2;
//             }
            
//             Console.WriteLine($"A soma dos quadrados dos 20 primeiros números impares é {soma}");

//             Console.WriteLine("Deseja realizar outro cálculo ? (S/N)");
//             string resposta = Console.ReadLine().ToUpper();
//             if( resposta == "N")
//             {
//                 Console.WriteLine("Código encerrado!!");
//                 break;
//             }
//         }
//     }
// }

// Exercício 33-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         int quantidadeAlunos = 0;
//         double notas = 0;

//         while (true)
//         {
//             // Solicita o número de matrícula do aluno
//             Console.WriteLine("Digite o número de matrícula do aluno (com no máximo 8 dígitos) ou 'sair' para finalizar:");
//             string entrada = Console.ReadLine();

//             if (entrada.ToLower() == "sair")
//                 break;

//             if (entrada.Length > 8 || !int.TryParse(entrada, out int matricula))
//             {
//                 Console.WriteLine("Número de matrícula inválido. Tente novamente.");
//                 continue;
//             }

//             // Solicita a nota do aluno
//             Console.WriteLine("Digite a nota do aluno (0 a 10):");
//             string entradaNota = Console.ReadLine();

//             if (!double.TryParse(entradaNota, out double novaNota) || novaNota < 0 || novaNota > 10)
//             {
//                 Console.WriteLine("Nota inválida. Tente novamente.");
//                 continue;
//             }

//             quantidadeAlunos++;
//             notas += novaNota;
//         }

//         if (quantidadeAlunos > 0)
//         {
//             double media = notas / quantidadeAlunos;
//             Console.WriteLine($"A média das notas dos {quantidadeAlunos} alunos é: {media:F2}");
//         }
//         else
//         {
//             Console.WriteLine("Nenhuma nota foi registrada.");
//         }
//     }
// }

// Exercício 34-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {   
        

//         int menor = int.MaxValue;
//         int maior = int.MinValue;

//         Console.WriteLine("Digite um numero positivo para continuar ou um número negativo para sair");
//         while (true)
//         {
//             string entrada = Console.ReadLine();
//             if (!int.TryParse(entrada, out int numero))
//             {
//                 Console.WriteLine("Entrada inválida.");
//                 continue;
//             }
//             if( numero < 0)
//             {
//                 Console.WriteLine("Código Encerrado");
//                 break;
//             }
//             if (numero < menor)
//             {
//                 menor = numero;
//             }
//             if( numero > maior)
//             {
//                 maior = numero;
                
//             }
//             if (menor == int.MaxValue && maior == int.MinValue)
//             {
//                 Console.WriteLine("Nenhum npumero foi registrado.");
//             } 
//             else
//             {
//                 Console.WriteLine($"O menor número é: {menor}");
//                 Console.WriteLine($"O maior numero é: {maior}");
//             }


//         }

//     }
// }

// Exercício 34.2--------------------------------------------


// using System;

// class Program
// {
//     static void Main()
//     {   
//         Console.WriteLine("Digite quantas vezes o código deve ser repetido ");
//         if(!int.TryParse(Console.ReadLine(), out int repetir )|| repetir <= 0 )
//         {
//             Console.WriteLine("Número Inválido.");
//             return;
//         }

//         int menor = int.MaxValue;
//         int maior = int.MinValue;

//         for (int i = 0; i < repetir; i++)
//         {   
//             Console.WriteLine("Digite um numero positivo para continuar ou um número negativo para sair");

//             if (!int.TryParse(Console.ReadLine(), out int numero) || numero < 0 )
//             {
//                 Console.WriteLine("Entrada inválida.");
//                 i--;
//                 continue;
//             }
//             if( numero < 0)
//             {
//                 Console.WriteLine("Código Encerrado");
//                 break;
//             }
//             if (numero < menor)
//             {
//                 menor = numero;
//             }
//             if( numero > maior)
//             {
//                 maior = numero;
                
//             }
//             if (menor == int.MaxValue && maior == int.MinValue)
//             {
//                 Console.WriteLine("Nenhum npumero foi registrado.");
//             } 
//             else
//             {
//                 Console.WriteLine($"O menor número é: {menor}");
//                 Console.WriteLine($"O maior numero é: {maior}");
//             }


//         }

//     }
// }

// Exercício 35-----------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {   

//        for(int i = 1; i <= 100; i++)
//        {
        
//          if(i % 10 == 0 )
//          {
//             Console.WriteLine($"{i} = Múltiplo de 10 "); 
//          }
//          else{
//             Console.WriteLine(i);
//          }
//        }
//     }
// }

// Exercício 36-----------------------------------------------

// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {  
//        int menor = int.MaxValue;
//        int maior = int.MinValue;
//        int soma = 0;
//        int adicionar = 0;
//        int[] values = new int[10];
//        Random random = new Random();

//        Console.WriteLine("Pressione Enter para gerar 10 números aleatórios");
//        Console.ReadLine();

//        while (adicionar < 10)
//        {
//         int numero = random.Next(1, 101);
//         values[adicionar] = numero;
//         Console.WriteLine($"Número gerado: {numero}");
        
//         if(numero < menor)
//         {
//             menor = numero;
//         }
//         if (numero > maior)
//         {
//             maior = numero;
//         }
//         soma = soma + numero;
//         adicionar++;
//        } 
//         double media = (double)soma / 10;
//         Thread.Sleep(2000);
//         Console.WriteLine("\nResultados:");
//         Console.WriteLine("Maior valor: " + maior);
//         Console.WriteLine("Menor valor: " + menor);
//         Console.WriteLine("Média: " + media);

//         Console.WriteLine("Pressione Enter para sair...");
//         Console.ReadLine();


//     }
// }

// Exercício 36-----------------------------------------------

using System;


class Program
{
    static void Main()
    {
       
    }
}