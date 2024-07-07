//Exercício 23----------------------------------------------------------

// using System;

// internal class Program
// {
//     private static void Main()
//     {
//         bool continuar = true;

//         while (continuar)
//         {
//             Console.WriteLine("Digite um Número: ");
//             double A = double.Parse(Console.ReadLine());  

//             Console.WriteLine("Digite um Número: ");
//             double B = double.Parse(Console.ReadLine());  
                

//             Console.WriteLine("Escolha uma opção: ");
//             Console.WriteLine("1 - Adição");
//             Console.WriteLine("2 - Subtração");
//             Console.WriteLine("3 - Multiplicação");
//             Console.WriteLine("4 - Divisão");

//             string resultado = Console.ReadLine();
            
//             int operacao;

//             if(int.TryParse(resultado, out operacao))
//             {   
//                 switch(operacao)
//                 {
//                     case 1:
//                         double soma = A + B;
//                         Console.WriteLine("Voce escolheu Adição");
//                         Console.WriteLine($"{A} + {B} = {soma}");
//                         break;
//                     case 2:
//                         double subtracao = A - B;
//                         Console.WriteLine("Você escolheu Subtração");
//                         Console.WriteLine($"{A} - {B} = {resultado}");
//                         break;
//                     case 3:
//                         double multiplicacao = A * B;
//                         Console.WriteLine("Você escolheu Multiplicação");
//                         Console.WriteLine($"{A} * {B} = {multiplicacao}");
//                         break;
//                     case 4:
//                         double divisao = A / B;
//                         Console.WriteLine("Você escolheu divisão");
//                         Console.WriteLine($"{A} / {B} {divisao}");
//                         break;
                    
//                 }
//                 Console.WriteLine("Pressione 'P' para parar ouqualquer outra tecla para continuar");
//                 var tecla = Console.ReadKey(true).Key;
//                 if(tecla == ConsoleKey.P)
//                 {
//                     continuar = false;
//                 }
//             }
//         }
//     }
// }

//Exercício 24----------------------------------------------------------

// using System;

// internal class Program
// {
//     private static void Main()
//     {
//         bool parar =  true;
//         while (parar)
//         {
//             Console.WriteLine("Digite um número: ");
//             int A = int.Parse(Console.ReadLine());

//             Console.WriteLine("Digite um número: ");
//             int  B = int.Parse(Console.ReadLine());

//             Console.WriteLine("1 - Verificar se um dos números lidos é ou não multiplo do outro");
//             Console.WriteLine("2 - Verificar se os dois números lidos são pares");
//             Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
//             Console.WriteLine("4 - Sair");

//             string opcao = Console.ReadLine();

//             int verificar;
//             if(int.TryParse(opcao, out verificar))
//             {
//                 switch(verificar)
//                 {
//                     case 1:
//                        if(A % B == 0 || B % A == 0)
//                        {
//                         Console.WriteLine("Um dos números é multiplo do outro");
//                        }
//                        else{
//                         Console.WriteLine("Nenhum dos números é multiplo");
//                        }
//                         break;
//                     case 2:
//                        if(A % 2 == 0 && B % 2 == 0 )
//                        {
//                         Console.WriteLine("Ambos os números são pares.");
//                        }
//                        else
//                        {
//                             Console.WriteLine("Um ou ambos os numeros são pares");
//                        }
//                        break;
                        
//                     case 3:
//                         double media = (A = B) / 2.0;
//                         if(media >= 7)
//                         {
//                             Console.WriteLine($"A média dos dois números é {media}, que é maior ou igual a 7.");
//                         }
//                         else
//                         {
//                             Console.WriteLine($"A média dos dois números é {media}, que é menor que 7.");

//                         }
//                         break;
//                     case 4:
//                         Console.WriteLine("Saindo...");
//                         parar = false;
//                         break;
                        
//                 }
//             }
//             Console.WriteLine("Código Encerrado!!");
//         }   
//     }
// }


//Exercício 24----------------------------------------------------------


// using System;

// internal class Program
// {
//     private static void Main()
//     {   
//         bool opcao = true;
//         while(opcao)
//         {   
//             Console.WriteLine("Fale sua Altura: ");
//             double altura = double.Parse(Console.ReadLine());

//             Console.WriteLine("Fale sua Sexualidade: ");
//             string sexo = Console.ReadLine();

//             Console.WriteLine("1 - Peso ideal Homens");
//             Console.WriteLine("2 - Peso ideal Mulheres");
//             Console.WriteLine("3 - Sair");

//             string resposta = Console.ReadLine();

//             switch(resposta)
//             {
//                 case "1":
//                     double pesoHomem = 72.7 * altura - 58;
//                     Console.WriteLine($"O peso ideal para um homem com {altura}m de altura é: {pesoHomem:F2} kg");
//                     break;
//                 case "2":
//                     double pesoMulher = 62.1 * altura - 44.7;
//                     Console.WriteLine($"O peso ideal para uma mulher com {altura}m de altura é: {pesoMulher:F2} kg");

//                     break;
//                 case "3":
//                     Console.WriteLine("Saindo...");
//                     opcao = false;
//                     break;
//             } 
//         }
//     }
// }

//FIM---------------------------------------------------------