// Nivel 2 Estruturas Condicionais

// Exercício 11-----------------------------------------------

// using System;

// internal class Program
// {
//     private static void Main()
//     {
//         Console.Write("Digite o númro A = ");
//         int A = int.Parse(Console.ReadLine());

//         Console.Write("Digite o númro B = ");
//         int B = int.Parse(Console.ReadLine());

//         if (A != B)
//         {
//             Console.WriteLine($"Troca efetuada A = {B}");
//             Console.WriteLine($"Troca efetuada B = {A}");
//         }
//         else
//         {   
//             Console.WriteLine("Números Iguais, Troca Efetuada");
//             Console.WriteLine($"Troca efetuada A = {B}");
//             Console.WriteLine($"Troca efetuada B = {A}");
//         }
//     }
// }

//Exercício 12------------------------------------------------

// using System;

// internal class Program
// {
//     private static void Main()
//     {
//         Console.WriteLine("Digite um número para verificar o Módulo");
//         int modulo = int.Parse(Console.ReadLine());

        
//         if(modulo >= 0)
//         {
//             Console.WriteLine($"O Módulo desse número é {modulo}");
//         }else
//         {
//             Console.WriteLine($"O Módulo desse número é {modulo}");
//         }
//     }
// }

//Exercício 13------------------------------------------------

// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.Write("Digite um número: ");
//         int A = int.Parse(Console.ReadLine());
        
//         Console.Write("Digite um número: ");
//         int B = int.Parse(Console.ReadLine());

//         Console.Write("Digite um número: ");
//         int C = int.Parse(Console.ReadLine());
    
//         if (A >= B && A >= C)
//         {
//             if (B >= C)
//             {
//                 Console.WriteLine($"Ordem Decrescente: {A}, {B}, {C}");
//             }else
//             {
//                 Console.WriteLine($"Ordem Decrescente: {A}, {C}, {B}");
//             }
//         }
//         else if ( B >= A && B >= C)
//         {
//             if (A >= C)
//             {
//                 Console.WriteLine($"Ordem Decrescente: {B}, {A}, {C}");
//             }else
//             {
//                 Console.WriteLine($"Ordem Decrescente: {A}, {C}, {A}");
//             }
//         }
//         else if (C >= A && C > B)
//         {
//             if (A >= B)
//             {
//                 Console.WriteLine($"Ordem Decrescente: {C}, {A}, {B}");
//             }else
//             {
//                 Console.WriteLine($"Ordem Decrescente: {C}, {B}, {A}");
//             }
//         }
//     }
// }   

//Exercício 14------------------------------------------------

// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.Write("Escreva um número: ");
//         int A = int.Parse(Console.ReadLine());

//         Console.Write("Escreva um número: ");
//         int B = int.Parse(Console.ReadLine());

//         int diferenca;

//         if (A >= B)
//         {
//             diferenca = A - B;
//             Console.WriteLine($"A diferença entre B = {B} e A = {A} é {diferenca}");
//         }else
//         {
//             diferenca = B - A;
//             Console.WriteLine($"A diferença entre B = {B} e A = {A} é {diferenca}");
//         }
//     }
// }

// Exercício 15-----------------------------------------------

// using System;
// using System.Threading;

// internal class Program
// {
//     static void Main()
//     {
      
//         Console.WriteLine("Digite sua nota: ");
//         double nota1 = double.Parse(Console.ReadLine());

//         Console.WriteLine("Digite sua nota: ");
//         double nota2 = double.Parse(Console.ReadLine());

//         Console.WriteLine("Digite sua nota: ");
//         double nota3 = double.Parse(Console.ReadLine());

//         Console.WriteLine("Digite sua nota: ");
//         double nota4 = double.Parse(Console.ReadLine());

//         double media = (nota1 + nota2 + nota3 + nota4) / 4;

//         if(media >= 7)
//         {
//             Console.WriteLine("Parabens você passou de Ano!!! Sua média foi {media}");
//         }else if(media < 7)
//         {   
//             Console.WriteLine($"Que pena sua nota foi {media} que é menor que a média da escola que é 7 ");
//             Console.WriteLine("Fique tranquilo, irei passar sua prova de recuperação, Estude e faça.");

//             Thread.Sleep(3000);
//             Console.WriteLine("...");
//             Thread.Sleep(3000);

//             Console.Write("Digite a sua nota de recuperação: ");
//             double recuperacao = double.Parse(Console.ReadLine());

//             double novaMedia = (recuperacao + media) / 2;

//             if(novaMedia >= 7)
//             {
//                 Console.WriteLine($"Parabens você passou!! Sua média foi {novaMedia}");
//             }
//             else
//             {
//                 Console.WriteLine($"Infelizmente você não passou sua média foi {novaMedia}");
//             }
//         }
//     }
// }

// Exercício 16-----------------------------------------------

// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int A = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite um número: ");
//         int B = int.Parse(Console.ReadLine());

//         if (A > B)
//         {
//             Console.WriteLine($"O amior número é {A} e o menor número é {B}");
            
//         }
//         else if (B > A)
//         {
//             Console.WriteLine($"O maior número é {B} e o menor número é {A}");
            
//         }
//         else{
//             Console.WriteLine($"Os Números {A} e {B} são iguais");
//         }
//     }
// }

// Exercício 17-----------------------------------------------


// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int inteiro = int.Parse(Console.ReadLine());

//         if(inteiro > 0 && inteiro < 9)
//         {
//             Console.WriteLine("Valor Válido");
//         }
//         else
//         {
//             Console.WriteLine("Valor Inválido");
//         }
//     }
// }

// Exercício 18-----------------------------------------------


// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int numero = int.Parse(Console.ReadLine());

//         switch(numero)
//         {
//             case 1:
//                 Console.WriteLine("Número Um Válido");
//                 break;
//             case 2:
//                 Console.WriteLine("Número Dois Válido");
//                 break;
//             case 3:
//                 Console.WriteLine("Número Três Válido");
//                 break; 
//             default:
//                 Console.WriteLine("Número Invalido");
//                 break;      
//         }
//     }
// }

// Exercício 19-----------------------------------------------


// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int A = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite um número: ");
//         int B = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite um número: ");
//         int C = int.Parse(Console.ReadLine());

//         if (A < B + C && B < A + C && C < A + B)
//         {
//             if(A == B && B == C)
//             {
//                 Console.WriteLine("Triângulo equilátero");
//             }
//             else if(A == B || A == C || B == C)
//             {
//                 Console.WriteLine("Triângulo isósceles");
//             }
//             else
//             {
//                 Console.WriteLine("Triângulo escaleno");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Os lados não forma um triângulo");
//         }
//     }
// }

// Exercício 20-----------------------------------------------


// using System;

// internal class Program
// {
//     static void Main()
//     {
//         bool repetir = true;
//         while(repetir)
//         {
//             Console.WriteLine("Digite um número: ");
//             int A = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite um número: ");
//             int B = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite um número: ");
//             int C = int.Parse(Console.ReadLine());

//             if(A  > 0 && B > 0 && C > 0)
//             {
//                 Console.WriteLine("Valor Válido");

//                 int menor = Math.Min(A, Math.Min(B, C));
//                 int maior = Math.Max(A, Math.Max(B, C));

//                 int multiplicacao = menor * maior;
//                 double divisao = (double)maior/menor;

//                 Console.WriteLine($"O menor valor lido é o {menor} e o maior valor lido é o {maior} multplicando, O {menor} pelo {maior} fica {multiplicacao}");
//                 Console.WriteLine($"O maior valor lido é o {maior} e o menor valor lido é o {menor} dividindo. O {maior} pelo {menor} fica {divisao}");
//                 break;

//             }else if(A < 0 && B < 0 && C < 0)
//             {
//                 Console.WriteLine("Valor Invalido");
//                 continue;
                
//             }
//         }
//     }
// }

// Exercício 21-----------------------------------------------



// using System;

// internal class Program
// {
//     static void Main()
//     {
//         bool parar = true;
//         while(parar)
//         {
//             Console.WriteLine("Digite um número: ");
//             int numero = int.Parse(Console.ReadLine());

//             if(numero > 0)
//             {
//                 Console.WriteLine($"Valor Positivo: {numero}");

//             }else if(numero < 0)
//             {
//                 Console.WriteLine($"Valor Negativo: {numero}");
//             }
//             Console.WriteLine("Pressione 'P' para parar ou qualquer outra tecla para continuar");
//             var tecla = Console.ReadKey(true).Key;
//             if(tecla == ConsoleKey.P)
//             {
//                 parar = false;
//             }
//         }
//     }
// }

// Exercício 22-----------------------------------------------

// using System;

// internal class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int numero = int.Parse(Console.ReadLine());

//         int A;
//         int B;

//         if(numero > 0)
//         {
//             A = numero;
//             Console.WriteLine($"{A} é um número positivo");
//         }
//         else
//         {
//             B = numero;
//             Console.WriteLine($"{B} é um número negetivo");
//         }
//     }
// }

//FIM---------------------------------------------------------