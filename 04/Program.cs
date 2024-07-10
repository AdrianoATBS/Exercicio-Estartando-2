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
 
//             Console.WriteLine("Digite o número de matrícula do aluno (com no máximo 8 dígitos) ou 'sair' para finalizar:");
//             string entrada = Console.ReadLine();

//             if (entrada.ToLower() == "sair")
//                 break;

//             if (entrada.Length > 8 || !int.TryParse(entrada, out int matricula))
//             {
//                 Console.WriteLine("Número de matrícula inválido. Tente novamente.");
//                 continue;
//             }


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

// Exercício 36---------------------------------------------------------

// using System;
// using System.Threading;


// class Program
// {
//     static void Main()
//     {
//        int[] valores = new int[10];
//        int maior = int.MinValue;
//        int menor = int.MaxValue;
//        int soma = 0;
//        Random random = new Random();

//        Console.WriteLine("10 valores inteiros: ");

//        for (int i = 0; i < 10; i++)
//         {
//             int valor = random.Next(1, 1001);
//             valores[i] = valor;

//             Console.WriteLine($"Valor {i + 1}: {valor}");
//             Thread.Sleep(1500);

//             if (valor > maior)
//             {
//                 maior = valor;
//             }
//             if(valor < menor)
//             {
//                 menor = valor;
//             }
//             soma = soma = valor;
//         } 

//         double media = soma / 10.0;

//         Console.WriteLine("\nResultado");
//         Console.WriteLine($"O maior valor é : {maior}");
//         Console.WriteLine($"O menor valor é: {menor}");
//         Console.WriteLine($"A média dos valores é {media:F2}");
//     }
// }

// Exercício 37---------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         bool repetir = true;
//         while(repetir)
//         {
//             Console.WriteLine("Escolha uma Opção");
//             Console.WriteLine("1 - Adição");
//             Console.WriteLine("2 - Subtração");
//             Console.WriteLine("3 - Multiplicação");
//             Console.WriteLine("4 - Divisão");
            
//             string opcao = Console.ReadLine();

//             if(opcao == "1" || opcao == "2"|| opcao == "3"|| opcao == "4") 
//             {
//                 Console.WriteLine("Digite o primeiro número: ");
//                 double numero1 = Convert.ToDouble(Console.ReadLine());

//                 Console.WriteLine("Digite o primeiro número: ");
//                 double numero2 = Convert.ToDouble(Console.ReadLine());

//                 double resultado = 0;

//                 switch(opcao)
//                 {
//                     case "1":
//                         resultado = numero1 + numero2;
//                         Console.WriteLine($"{numero1} + {numero2} = {resultado}");
//                         break;

//                     case "2":
//                         resultado = numero1 - numero2;
//                         Console.WriteLine($"{numero1} - {numero2} = {resultado}");
//                         break;

//                     case "3":
//                         resultado = numero1 * numero2;
//                         Console.WriteLine($"{numero1} * {numero2} = {resultado}");
//                         break;

//                     case "4":
//                         resultado = numero1 / numero2;
//                         Console.WriteLine($"{numero1} * {numero2} = {resultado}");
//                         break;
//                 }
//                 Console.WriteLine("Deseja voltar ao menu principal (s/n)? ");
//                 string resposta = Console.ReadLine();
//                 if(resposta.ToLower() != "s")
//                 {
//                     repetir = false;
//                 }
//                 else if(resposta.ToLower() != "n")
//                 {
//                     repetir = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Opção Inválida");
//                 }
//             }
//         }
//         Console.WriteLine("Código Encerrado!");
//     }
// }

// Exercício 38---------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         const double salarioHora = 10.00;
//         const double salarioHoraExcedente = 20.00;
//         bool repetir = true;

//         while(repetir)
//         {
//             Console.WriteLine("Digite o código do operário (Não pode passar de 6 Digitos):  ");

//             string codigo = Console.ReadLine();

//             if(codigo.ToUpper() == "SAIR")
//             {

//             }
//             if (codigo.Length > 6 || !int.TryParse(codigo, out int novoCodigo))
//             {
//                 Console.WriteLine("Número de matrícula inválido. Tente novamente.");
//                 continue;
//             }
//             Console.WriteLine("Digite o número de horas trabalhadas: ");
//             int horasTrabalhadas = int.Parse(Console.ReadLine());

//             double salarioExcedente = 0;
//             double salarioTotal = 0;

//             if( horasTrabalhadas > 50)
//             {
//                 int horasExcedentes = horasTrabalhadas - 50;
//                 salarioExcedente = horasExcedentes * salarioHoraExcedente;
//                 salarioTotal = (50 * salarioHora) + salarioExcedente;
//             }
//             else
//             {
//                 salarioTotal = horasTrabalhadas * salarioHora;
//             }
//             Console.WriteLine($"Código do Operário: {codigo}");
//             Console.WriteLine($"Salário Total: R$ {salarioTotal:F2}");
//             Console.WriteLine($"Salário Excedente: R$ {salarioExcedente:F2}");

//             Console.Write("Deseja encerrar o progama ? (s/n)");
            
//             string resposta = Console.ReadLine();
//             if (resposta.ToLower() == "s")
//             {   
                
//                 repetir = false;
//             }
//             else if(resposta.ToLower() == "n")
//             {
//                 repetir = true;
//             }
//         }
//         Console.WriteLine("Progama Encerrado.");
//     }
// }

// Exercício 39---------------------------------------------------------


// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("Digite um número: ");
//             int numero = int.Parse(Console.ReadLine());
            
//             string parImpar = (numero % 2 == 0) ? "par" : "impar";
//             string posNeg = (numero > 0) ? "positivo" : "negativo";

//             Console.WriteLine($"O número {numero} é {parImpar} e {posNeg}");

//             Console.WriteLine("Deseja Encerrar ? (S ou outra tecla para não)");
//             string respsota = Console.ReadLine();

//             if(respsota.ToUpper() == "S")
//             {
//                 break;    
//             }
//         }   
//         Console.WriteLine("Progama Encerrado.");
//     }
// }

// Exercício 40---------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         bool repetir = true;
//         while (repetir)
//         {
//             Console.WriteLine("Escolha uma Opção: ");
//             Console.WriteLine("1 - 0.05 até 0.25");
//             Console.WriteLine("2 - 0.3 ");
//             Console.WriteLine("3 - 0.4");
//             Console.WriteLine("4 - 0.5");
//             Console.WriteLine("5 - sair");
//             string opcao = Console.ReadLine();

//             switch (opcao)
//             {
//                 case "1":
//                     Console.WriteLine("Índice de poluição dentro do aceitável.");
//                     break;

//                 case "2":
//                     Console.WriteLine("Indústrias do 1º grupo devem suspender suas atividades.");
//                     break;

//                 case "3":
//                     Console.WriteLine("Indústrias do 1º e 2º grupo devem suspender suas atividades.");
//                     break;
//                 case "4":
//                     Console.WriteLine("Todas as indústrias devem suspender suas atividades.");
//                     break;     
//                 case "5":
//                     repetir = false;
//                     Console.WriteLine("Saindo...");
//                     break;    
//             }   
//         }
//     }
// }


// Exercício 41---------------------------------------------------------

// using System;

// class Program
// {
//     static void Main()
//     {
//         bool repetir = true;
//         while (repetir)
//         {   
//             Console.WriteLine("Para saber sua categoria, fale sua idade:");
//             int idade = int.Parse(Console.ReadLine());

//             if(idade >= 5 && idade <= 7)
//             {
//                 Console.WriteLine("Sua categoria: Infantil A = 5 a 7 anos");
//             }
//             else if(idade >= 8 && idade <= 11)
//             {
//                Console.WriteLine("Sua categoria: Infantil B = 8 a 11 anos"); 
//             }
//             else if(idade >= 12 && idade <= 13)
//             {
//                 Console.WriteLine("Sua categoria: Juvenil A = 11 a 13 anos"); 
//             }
//             else if(idade >= 14 && idade <= 17)
//             {
//                 Console.WriteLine("Sua categoria: Juvenil B = 14 a 17 anos"); 
//             }
//             else if (idade >= 18)
//             {
//                 Console.WriteLine("Sua categoria: Adulto = 18 anos para cima"); 
//             }
//             else
//             {
//                 Console.WriteLine("Idade inválida");
//             }
//             Console.WriteLine("Deseja Encerrar ? (S/N)");
//             string resposta = Console.ReadLine();
            
//             if(resposta.ToUpper() == "S")
//             {
//                 repetir = false;
//             }
//             else if (resposta.ToUpper() == "N")
//             {
//                 repetir = true;
//             }
//         }
//         Console.WriteLine("Encerrando o código");
//     }
// }

// Exercício 42---------------------------------------------------------

// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();

//         int maior = int.MinValue;
//         int menor = int.MaxValue;

//         Console.WriteLine("Gerando números...");

//         while(true)
//         {
//             int numero = random.Next(101);

//             Console.WriteLine($"Número gerado: {numero}");
//             if(numero == 0)
//             {
//                 break;
//             }
//             if(numero > maior)
//             {
//                 maior = numero;
//             }
//             if(numero < menor)
//             {
//                 menor = numero;
//             }      
//         }
//             Console.WriteLine($"O maior número gerado é: {maior}");
//             Console.WriteLine($"O menor número gerado é: {menor}");       
//     }
// }

<<<<<<< HEAD
// Exercício 36-----------------------------------------------
=======
// Exercício 43---------------------------------------------------------

// using System;
// // using System.Numerics; BigInteger numero = BigInteger.Parse("123456789012345678901234567890");

// class Program
// {
//     static void Main()
//     {
//         ulong totalDeGraos = 0;
//         ulong grao = 1;

//         for(int i = 1; i <= 64; i++)
//         {
//             totalDeGraos = totalDeGraos + grao;
//             grao = grao * 2;
//         }
//         Console.WriteLine($"O Monge esperava receber: {totalDeGraos}");
//     }
// }

// Exercício 44---------------------------------------------------------

// using System;


// class Program
// {
//     static void Main()
//     {
//         string escolha = "";

//         while (escolha != "5")
//         {
//             Console.WriteLine("Escolha uma Opção: ");
//             Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
//             Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
//             Console.WriteLine("3 – Peso ideal do homem");
//             Console.WriteLine("4 – Peso ideal da mulher");
//             Console.WriteLine("5 – Encerrar o programa");
            
//             escolha = Console.ReadLine().ToUpper();

//             if(escolha == "1")
//             {
//                 Console.Write("Digite a temperatura em graus Celsius: ");
//                 double celsius = double.Parse(Console.ReadLine());
//                 double fahrenheit = celsius * 9 / 5 + 32;
//                 Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
//             }
//             else if(escolha == "2")
//             {
//                 Console.Write("Digite a temperatura em graus Fahrenheit: ");
//                 double fahrenheit = Convert.ToDouble(Console.ReadLine());
//                 double celsius = (fahrenheit - 32) * 5 / 9;
//                 Console.WriteLine($"{fahrenheit}°F equivalem a {celsius}°C");
//             }
//             else if (escolha == "3")
//             {
//                 Console.Write("Digite a altura em metros: ");
//                 double altura = Convert.ToDouble(Console.ReadLine());
//                 double pesoIdealHomem = (72.7 * altura) - 58;
//                 Console.WriteLine($"O peso ideal para um homem de {altura}");

//                 Console.Write("Digite o peso atual em kg: ");
//                 double pesoAtualHomem = Convert.ToDouble(Console.ReadLine());

//                 if (pesoAtualHomem < pesoIdealHomem)
//                 {
//                     Console.WriteLine("Você está abaixo do peso ideal.");
//                 }
//                 else if (pesoAtualHomem > pesoIdealHomem)
//                 {
//                     Console.WriteLine("Você está acima do peso ideal.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Você está no peso ideal.");
//                 }
//             }
//             else if (escolha == "4")
//             {
//                 Console.Write("Digite a altura em metros: ");
//                 double altura = Convert.ToDouble(Console.ReadLine());
//                 double pesoIdealMulher = (62.1 * altura) - 44.7;
//                 Console.WriteLine($"O peso ideal para uma mulher de {altura}m é {pesoIdealMulher}kg");

//                 Console.Write("Digite o peso atual em kg: ");
//                 double pesoAtualMulher = Convert.ToDouble(Console.ReadLine());

//                 if (pesoAtualMulher < pesoIdealMulher)
//                 {
//                     Console.WriteLine("Você está abaixo do peso ideal.");
//                 }
//                 else if (pesoAtualMulher > pesoIdealMulher)
//                 {
//                     Console.WriteLine("Você está acima do peso ideal.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Você está no peso ideal.");
//                 }
//             }  
//             else if(escolha != "5")
//             {
//                 Console.WriteLine("Opção Inválida! ");
//             }

//         }
//         Console.WriteLine("Encerrando o progama");
//     }
// }

// FIM ---------------------------------------------------------
>>>>>>> 7eb0648ea2a071ac69f871e1b02f8e10bf8dfb92
