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

using System;

class Program
{
    static void Main()
    {      
       int par = 0;
       int impar = 0;

       Console.WriteLine("Digite a quantidade de números: ");
       int quantidade = int.Parse(Console.ReadLine());

       for(int i =0; i < quantidade; i++)
       {
            Console.WriteLine($"Digite um número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                    Console.WriteLine("Número negativo. Digite números Positivo");
                    break;

                if ( numero % 2 == 0)
                {
                    Console.WriteLine($"O número {numero} é par");
                    par += numero;
                    
                }
                else
                {
                    Console.WriteLine($"O número {numero} é impar");
                    impar += numero;
                }  
       }
       Console.WriteLine($"A soma é dos números pares é {par}");
        Console.WriteLine($"A soma é dos números impares é {impar}");
        Console.WriteLine("Código Encerrado!");
       
    }
}