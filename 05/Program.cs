//Exercício 45----------------------------------------------------------

// using System;


// class Program
// {
//     static void Main()
//     {
        
//         Random random = new Random();
//         int tamanho = 5;
//         int[] vetor = new int[tamanho];

//         for(int i = 0; i < tamanho; i++)
//         {
//             vetor[i] = random.Next(1, 101);
//             Console.WriteLine(vetor[i]);
//         }
//         Console.WriteLine("======================");
//         for(int i = tamanho - 1; i >= 0; i--)
//         {
            
//             Console.WriteLine(vetor[i]);
//         }

//     }
// }

//Exercício 46----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
      
//         int tamanho = 5;

//         int[] x = new int[tamanho];
//         int[] y = new int[tamanho];
//         Random random = new Random(tamanho);

//         for (int i = 0; i < tamanho; i++)
//         {
//             x[i] = random.Next(1, 101);
//             y[i] = random.Next(1,101);
//         }
//         int produto = 0;
//         for (int i = 0; i < tamanho; i++) 
//         {
//             produto = produto + x[i] * y[i];
//         }
//         Console.WriteLine("Vetor x: " + string.Join(", ", x));
//         Console.WriteLine("Vetor y: " + string.Join(", ", y));

       
//         Console.WriteLine("O produto escalar dos vetores x e y é: " + produto);
//     }
// }

//Exercício 47----------------------------------------------------------
// using System;

// class Program
// {
//     static void Main()
//     {
//         int tamanho = 10;
//         int[] vetor = new int[tamanho];

//         Random random = new Random();

//         for (int i = 0; i< tamanho; i++)
//         {
//             vetor[i] = random.Next(1, 10);
//         }
//         Console.WriteLine("Vetor ggerado: ");
//         for(int i = 0; i < tamanho; i++)
//         {
//             Console.WriteLine(vetor[i] + " ");
//         }
//         Console.WriteLine();
        
//         int x;
//         while(true)
//         {
//             Console.WriteLine("Digite um número inteiro positivo e maior que zero (X): ");
//             if(int.TryParse(Console.ReadLine(), out x) && x > 0)
//             {
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Número inválido.");
//             }
//         }
//         int maioresQueX = 0, menoresQueX = 0, iguaisAX = 0;

//         foreach (int numero in vetor)
//         {
//             if (numero > x)
//             {
//                 maioresQueX++;
//             }
//             else if (numero < x)
//             {
//                 menoresQueX++;
//             }
//             else
//             {
//                 iguaisAX++;
//             }
//         }

      
//         Console.WriteLine($"\nQuantidade de números no vetor:");
//         Console.WriteLine($"- Maiores que X ({x}): {maioresQueX}");
//         Console.WriteLine($"- Menores que X ({x}): {menoresQueX}");
//         Console.WriteLine($"- Iguais a X ({x}): {iguaisAX}");
//     }
// }

//Exercício 48----------------------------------------------------------

// using System;
// class Program
// {
//     static void Main()
//     {
//         string [] nomes = { "Alice", "Bianca", "Clara", "Diana", "Elena", "Fernanda", "Gabriela", "Helena", "Isabela", "Juliana", "Larissa", "Manuela", "Natália", "Olivia", "Patrícia", "Renata", "Sabrina", "Tatiana", "Ursula", "Vivian" };

//         int totalCandidatas = 20;
//         Random random = new Random();

//         string[] canNomes = new string[totalCandidatas];
//         int[] canIdade = new int[totalCandidatas];

//         for (int i = 0;i< totalCandidatas; i++)
//         {
//             int indiceNome = random.Next(nomes.Length);
//             canNomes[i] = nomes[indiceNome];

//             canIdade[i] = random.Next(18, 26);
//         }

//         Console.WriteLine("Candidatas aptas a concorrer a vaga na campanha: ");
//         for(int i = 0; i < totalCandidatas; i++)
//         {
//             if(canIdade[i] >= 18 && canIdade[i] <= 20)
//             {
//                 Console.WriteLine($"{canNomes[i]} - {canIdade[i]} anos");
//             }
//         }
//     }
// }

//Exercício 49----------------------------------------------------------

using System;
class Program
{
    static void Main()
    {
    }
}