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
//         Console.WriteLine("Vetor gerado: ");
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

// using System;
// class Program
// {
//     static void Main()
//     {   
        
//         Random random = new Random();
//         int numero = random.Next(1, 51);

//         int[] v1 = new int[numero];
//         int[] v2 = new int[numero];

//         for(int i = 0; i < numero;i++)
//         {
//             v1[i] = random.Next(0, 51);
//             v2[i] = random.Next(0, 51);
//         } 
//         int contar = 0;

//         for (int i = 0; i < numero; i++)
//         {
//             if(v1[i] == v2[i])
//             {
//                 contar++;
//                 // Console.WriteLine($"Vetor V1:" + string.Join(",", v1));
//                 // Console.WriteLine($"Vetor V2:" + string.Join(",", v2));
//             }
//         }
//         Console.WriteLine($"Vetor V1: " + string.Join(", ", v1));
//         Console.WriteLine($"Vetor V2: " + string.Join(",", v2));
//         Console.WriteLine($"\nValores idênticos {contar}");
//     }
// }

//Exercício 50----------------------------------------------------------

// using System;
// class Program
// {
//     static void Main()
//     {   
//         Random random = new Random();
//         int numero = random.Next(1, 101);
//         int tentativa;
//         int tentativas = 0;
//         bool acertou = true;

//         Console.WriteLine("Advinhe o número sorteado entre 0 a 100");

//         while (acertou)
//         {
//             Console.WriteLine("Digite um número: ");
//             tentativa = int.Parse(Console.ReadLine());
//             tentativas ++;
//             {
//                 if (tentativa == numero)
//                 {
//                     Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas");
//                     break;
//                 }
//                 else if(tentativa < numero)
//                 {
//                     Console.WriteLine("Digite um número maior.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Digite um número menor.");
//                 }
//             }
//         }
//         Console.WriteLine("Código encerrado!");
//     }
// }

//Exercício 51----------------------------------------------------------

// using System;
// class Program
// {
//     static void Main()
//     { 
//         Random random = new Random();
       
//         int N = random.Next(1, 11);
//         int[] nota = new int[N];

//         int soma = 0;
//         int acimaDeSete = 0;
//         bool acimaDeCinco = true;

//         for(int i = 0;  i < N; i++)
//         {
//             nota[i] = random.Next(1, 11);
//             soma = soma + nota[i];

//             if(nota[i] > 7.0)
//             {
//                 acimaDeSete++;
//             }
//             if(nota[i] > 5.0)
//             {
//                 acimaDeCinco = false;
//             }
//         }
//          double media = (double)soma / N;

//          Console.WriteLine("Notas dos alunos: ");
//          for (int i = 0; i < N; i++)
//          {
//             Console.WriteLine($"Alunos {i + 1}: {nota[i]}");
//          }

//          Console.WriteLine($"Média aritmética das notas: {media:F2}");

//          Console.WriteLine($"Quantidade de alunos com nota acima de 7.0: {acimaDeSete}");
         

//         if(acimaDeCinco )
//          {
//             Console.WriteLine("Não tem alunos com notas acima de 5.0. Precisam de reforço");
//          }
       
//     }
// }

//Exercício 52----------------------------------------------------------


// using System;
// class Program
// {
//     static void Main()
//     { 
//         int maxTamanho = 100;
//         int[] vetor = new int[maxTamanho];
//         int tamanho = 0;

//         Random random = new Random();

//         for (int i = 0; i < maxTamanho; i++)
//         {
//             vetor[i] = random.Next(0,101);
//             tamanho++;
//         }
        
//         int contador1 = 0, contador3 = 0, contador4 = 0;

//         for(int i = 0; i < tamanho; i++)
//         {
//             if (vetor[i] == 1)
//             {
//                 contador1++;
//             }
//             else if(vetor[i] == 3)
//             {
//                 contador3++;
//             }
//             else if(vetor[i] == 4)
//             {
//                 contador4++;
//             }
//         }
//         Console.WriteLine($"Número 1 aparece {contador1} vezes");
//         Console.WriteLine($"Número 3 aparece {contador3} vezes");
//         Console.WriteLine($"Número 4 aparece {contador4} vezes");
//         Console.WriteLine("\nCódigo Encerrado.");
//     }
// }

//Exercício 53----------------------------------------------------------

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite a quantidade de voltas {N}: ");
//         int voltas = int.Parse(Console.ReadLine());

//         if(voltas <= 0)
//         {
//             Console.WriteLine("Número inválido.");
//             return;
//         }

//         int[] tempos = new int[voltas];

//         for(int i = 0; i < voltas; i++)
//         {
//             Console.WriteLine($"Digite o tempo da volta {i + 1}: ");
//             tempos[i] = int.Parse(Console.ReadLine());
//         }

//         int melhorTempo = int.MaxValue;
//         int voltaMelhorTempo =  -1;

//         for(int i = 0; i < voltas; i++)
//         {
//             if(tempos[i] < melhorTempo)
//             {
//                 melhorTempo = tempos[i];
//                 voltaMelhorTempo = i + 1;
//             }
//         }
//         double somaTempo = 0;

//         for(int i = 0; i <voltas; i++)
//         {
//             somaTempo = somaTempo + tempos[i];	
//         } 
//         double tempoMedio = somaTempo / voltas;

//         Console.WriteLine($"Melhor tempo: {melhorTempo} segundos");
//         Console.WriteLine($"Volta do melhor tempo: {voltaMelhorTempo}");
//         Console.WriteLine($"Tempo médio das {voltas} voltas: {tempoMedio:F2} segundos");
//     }
// }

//Exercício 54----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();

//         int[] A = new int[5];
//         int[] B = new int[8];

//         for (int i = 0; i < A.Length; i++)
//         {
//             A[i] = random.Next(1, 11);
//         }
//         for (int i = 0; i < B.Length; i++)
//         {
//             B[i] = random.Next(1,11);
//         }
//         Console.WriteLine($"Vetor A:" + string.Join(",",A));
//         Console.WriteLine($"Vetor B:" + string.Join(",",B));

//         foreach (int numA in A)
//         {
//             foreach (int numB in B)
//             {
//                 if (numA == numB)
//                 Console.WriteLine(numA + " ");
//                 break;
//             }
//         }
//         Console.WriteLine("Código Encerrado.");
//     }
// }

//Exercício 55----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite uma frase de até 50 caracteres: ");
//         string frase = Console.ReadLine();

//         if(frase.Length > 50)
//         {
//             Console.WriteLine("A frase tem mais de 50 caracteres. ");
//             return;
//         }
//         int contarEspacos = 0;
//         string fraseSemEspacos = "";

//         for (int i = 0; i < frase.Length; i++)
//         {
//             char c = frase[i];
//             if (c != ' ')
//             {
//                 fraseSemEspacos = fraseSemEspacos + c;
//             }
//             else
//             {
//                 contarEspacos++;
//             }
//         }
//         Console.WriteLine("Frase sem espaços em branco ");
//         Console.WriteLine(fraseSemEspacos);
//         Console.WriteLine($"Quantidade de espaços em branco removidos: {contarEspacos}");
//     }
// }

//Exercício 56----------------------------------------------------------
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int[] vetor = new int[50];
//         int quantidadePares = 0;
//         int multiplos = 0;

//         for (int i = 0; i < vetor.Length; i++)
//         {
//             vetor[i] = random.Next(1, 101);
//         }
//         Console.WriteLine("Números do vetor: ");

//         for(int i = 0; i < vetor.Length; i++)
//         {
//             if(vetor[i] % 2 == 0)
//             {
//                 quantidadePares++;
//             }
//             if (vetor[i] % 5 == 0)
//             {
//                 multiplos++;
//             }
            
//         }
    
//         Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
//         Console.WriteLine($"Quantidade de números múltiplos de 5: {multiplos}");
//     }

// }

//Exercício 57----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite uma frase: ");
//         string  frase = Console.ReadLine().ToLower();
//         string vogais = "aeiou";

//         Console.WriteLine("Vogais na frase: ");

//         for (int i = 0; i < frase.Length; i++) 
//         {
//             char c = frase[i];
            
//             if(vogais.Contains(c))
//             {
//                 Console.WriteLine(c + " ");
//             }

//         }
//         Console.WriteLine("Código Encerrado.");
//     }
// }

//Exercício 58----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite a quantidade vezes desejada: ");
//         int quantidade = int.Parse(Console.ReadLine());

//         int[] numeros = new int[quantidade];

//         int soma = 0;

//         for(int i = 0; i < quantidade; i++)
//         {
//             Console.Write($"Digite o {i + 1}º números: ");
//             numeros[i] = int.Parse(Console.ReadLine());

//             soma = soma + numeros[i];
//         }
        
//         double media = (double)soma / quantidade;

//         int maior = numeros[0];

//         for(int i = 1; i < quantidade; i++)
//         {
//             if(numeros[i] > maior)
//             {
//                 maior = numeros[i];
//             }
//         }
//         Console.WriteLine($"Média dos números: {media}");
//         Console.WriteLine($"Maior número: {maior}");
//     }
// }

//Exercício 59----------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma letra entre A a Z: ");
        char letra1 = char.Parse(Console.ReadLine().ToLower());

        Console.WriteLine("Digite uma letra entre A a Z: ");
        char letra2 = char.Parse(Console.ReadLine().ToLower());

        if(letra1 < 'a' || letra1 > 'z' || letra2 < 'a' || letra2 > 'z')
        {
            Console.WriteLine("Letra inválida");
        }
        else if(letra1 >= letra2)
        {
            Console.WriteLine("Letra inválida.");
        }
        else
        {
            int caracteres = letra2 - letra1 - 1;
            Console.WriteLine($"O número de caracteres entre {letra1} e {letra2} é {caracteres}");
        }
    }
}

//Exercício Fim---------------------------------------------------------
