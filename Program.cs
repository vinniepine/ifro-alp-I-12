/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 *
 * Acadêmico Vinícius de Oliveira Pinheiro
 */

// Revisão para a Prova de Algoritmo e Lógica 1
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@"


    ---------------------------------------------------------------
    Instituto Federal de Educação, Ciência e Tecnologia de Rondônia
    ---------------------------------------------------------------

           ________      ______     ______        ______      
          /_______/\    /_____/\   /_____/\      /_____/\     
          \__.::._\/    \::::_\/_  \:::_ \ \     \:::_ \ \    
             \::\ \      \:\/___/\  \:(_) ) )_    \:\ \ \ \   
             _\::\ \__    \:::._\/   \: __ `\ \    \:\ \ \ \  
            /__\::\__/\    \:\ \      \ \ `\ \ \    \:\_\ \ \ 
            \________\/     \_\/       \_\/ \_\/     \_____\/ 
       
    --------------------------------------------------------------- 

           C.S.T. em Análise e Desenvolvimento de Sistemas.
           Disciplina de Algoritmo e Lógica 1
           Professor Clayton Ferraz Andrade
           Acadêmico Vinicius de Oliveira Pinheiro

    ---------------------------------------------------------------
    ");
Console.ReadLine();
while (true)
{
    Console.Clear();
    Console.WriteLine(@"


    -------------------------------------------------------
                                                         
       Exercícios de prática para a avaliação             
                                                         
           Lista [01]                                       
           Lista [02]                                       
                                                          
       Qual lista deseja ver?                             
                                                         
    -------------------------------------------------------""


");
    int lista = int.Parse(Console.ReadLine());
    switch (lista) 
    {
        case 01 or 01:
            do
            {
                Console.Clear();
                Console.WriteLine(@"


    ----------------------------------------------------------
                                                         
       Lista [01] de exercícios de prática para a avaliação  
                                                         
           Exercício [01] - Adição de dois valores         
           Exercício [02] - Números na ordem inversa        
           Exercício [03] - Graus celsius e fahrenheit      
           Exercício [04] - Quadrado e Cubo de 'n'          
           Exercício [05] - Multiplicação e adição          
                                                          
       Qual exercício você gostaria de verificar?         
                                                          
    ----------------------------------------------------------");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1 or 01:
                        // Um algoritmo que leia dois números inteiros, some-os e apresente o valor calculado.
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este é um algortimo que lê dois números inteiros,\n    soma-os e apresenta o valor final.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("    Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\n    {num1} + {num2} = {num1+num2}.");
                        Console.ReadLine();
                        break;
                    case 2 or 02:
                        // Um algoritmo que lê dois números na ordem inversa da entrada;
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algoritmo lê dois números na ordem inversa da entrada.");
                        Console.WriteLine("    Digite o primeiro número, por favor: ");
                        int numA = int.Parse(Console.ReadLine());
                        Console.WriteLine("    Digite o segundo númeo, por favor: ");
                        int numB = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Os números digitados foram {numA} e {numB}.");
                        Console.ReadLine();
                        break;
                    case 3 or 03:
                        int fahrenheit;
                        // Um algortimo que leia uma temperatura em Celsius e apresente-a em graus Fahrenheit.
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algoritmo lê a temperatura em graus Celsius e a converte em Fahrenheit.");
                        Console.WriteLine("    Digite uma temperatura em Celsius: ");
                        int celsius = int.Parse(Console.ReadLine());
                        fahrenheit = (celsius * 9 + 160) / 5;
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    {celsius}°C = {fahrenheit}°F.");
                        Console.ReadLine();
                        break;
                    case 4 or 04:
                        // Um algoritmo que lê um valor inteiro e apresenta os resultados do quadrado e do cubo do valor lido.
                        Console.Clear();   
                        Console.WriteLine("\n\n\n\n    Este algoritmo lê um número e apresenta seu quadradoe e seu cubo.");
                        Console.WriteLine("    Digite o número que deseja: ");
                        double numeric = double.Parse(Console.ReadLine());
                        double squared = Math.Pow(numeric,2);
                        double cubic = Math.Pow(numeric, 3);
                        Console.WriteLine($"    {numeric}^2 = {squared}\n    {numeric}^3 = {cubic}");
                        Console.ReadLine();
                        break;
                    case 5 or 05:
                        // Um algoritmo que lê quatro números e apresenta a adição e multiplicação dos valores entre si.
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Este algortimo lê 4 números mostra a adição e multiplicação dos valores entre si: ");
                        Console.WriteLine("    Digite o primeiro número: ");
                        int numero1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Digite o segundo número: ");
                        int numero2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Digite o terceiro número: ");
                        int numero3 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Digite o quarto número: ");
                        int numero4 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    {numero1} + {numero2} = {numero1 + numero2}\n    {numero1} + {numero3} = {numero1 + numero3}\n    {numero1} + {numero4} = {numero1 + numero4}\n    {numero2} + {numero3} = {numero2 + numero3}\n    {numero2} + {numero4} = {numero2 + numero4}\n    {numero3} + {numero4} = {numero3 + numero4}.\n");
                        Console.WriteLine($"    {numero1} x {numero2} = {numero1 * numero2}\n    {numero1} x {numero3} = {numero1 * numero3}\n    {numero1} x {numero4} = {numero1 * numero4}\n    {numero2} x {numero3} = {numero2 * numero3}\n    {numero2} x {numero4} = {numero2 * numero4}\n    {numero3} x {numero4} = {numero3 * numero4}.\n");
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("    Desculpe, eu não entendi. Poderia Repetir?");
                        break;
                }
                Console.Clear();
                Console.WriteLine(@"
 


    Deseja sair ou verificar outro exercício?

    Se deseja continuar, aperte [1]
    Se deseja encerrar, aperte [2]");
                int yerOrNo = int.Parse(Console.ReadLine());
                if (yerOrNo == 2)
                {
                    break;
                }
            } while (true);
            break;
 
        case 2 or 02:
            do
            {
                Console.Clear();
                Console.WriteLine(@"


    ----------------------------------------------------------
                                                         
       Lista [02] de exercícios de prática para a avaliação  
                                                         
           Exercício [01] - Média, soma e menor número      
           Exercício [02] - Soma de números de 1 a 100      
           Exercício [03] - Par ou ímpar; +/-               
           Exercício [04] - Leitura de números              
           Exercício [05] - Tabuada de 'n' a 10             
           Exercício [06] - Salários de uma empresa         
           Exercício [07] - Fibonacci                       
                                                         
       Qual exercício você gostaria de verificar?         
                                                         
    ----------------------------------------------------------");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1 or 01:
                    // Crie um programa que peça 10 números inteiros e apresente: a média, a soma e o menor.
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Esse algoritmo faz a média aritmética de 10 números");
                    double sum = 0, smallest = double.MaxValue;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("    Por favor, insira um número: ");
                        int number = int.Parse(Console.ReadLine());
                        sum += number;
                        if (number == 0)
                        {
                            i--;
                        }
                        if (number < smallest)
                        {
                            smallest = number;
                        }
                    }
                    double average = sum / 10;
                    Console.Clear();
                    Console.WriteLine($"\n\n\n\n    A soma total dos número é: {sum}.");
                    Console.WriteLine($"    A média dos números digitados é: {average}.");
                    Console.WriteLine($"    O menor algarismo digitado foi: {smallest}");
                    Console.ReadLine();
                        break;

                    case 2 or 02:
                    // Some os números de 1 a 100, e imprima o valor.
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Esse algoritmo soma os números de 1 a 100!");
                    Console.ReadLine();
                    int soma = 0, numero;
                    for (int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine($"    {soma} + {i} = ");
                        soma += i;
                        Console.WriteLine($"    {soma}");
                    }
                    Console.WriteLine($"\n    A soma dos números de 1 a 100 é: {soma}.");
                    Console.ReadLine();
                        break;
                    case 3 or 03:
                    /* Faça um algoritmo que leia um número inteiro e mostre uma mensagem
                     * indicando se este número é par ou ímpar, e se é positivo ou negativo.
                     */
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Este algoritmo lê um número inteiro e diz se ele é\n    par ou ímpar, positivo ou negativo.\n");
                    Console.WriteLine("    Por favor, digite um número: \n");
                    int algarismo = int.Parse(Console.ReadLine());
                    if (algarismo == 0)
                    {
                        Console.WriteLine("    O número zero neutro");
                    }
                    if (algarismo > 0)
                    {
                        Console.WriteLine("    O número digitado é positivo.");
                    }
                    if (algarismo < 0)
                    {
                        Console.WriteLine("    O número digitado é negativo.");
                    }
                    if (algarismo % 2 == 0 && algarismo != 0)
                    {
                        Console.WriteLine("    O número digitado é par.");

                    }
                    else if (algarismo % 2 != 0 && algarismo != 0)
                    {
                        Console.WriteLine("    O número digitado é ímpar.");
                    }
                    Console.ReadLine();
                        break;
                    case 4 or 04:
                    /* Faça um algoritmo que leia números até o usuário digitar 0, após
                     * finalizar, mostre quantos números lidos, a soma e quantos são pares.
                    */
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Este algoritmo lê números até que o usuário digite 0.");
                    Console.ReadLine();
                    int quantidade = 0, somatória = 0, pares = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n    Digite um número: ");
                        int numeral = int.Parse(Console.ReadLine());
                        quantidade++;
                        somatória += numeral;
                        if (numeral % 2 == 0)
                        {
                            pares++;
                        }
                        if (numeral == 0)
                        {
                            break;
                        }
                    } while (true);
                    Console.Clear();
                    Console.WriteLine($"\n\n\n\n    {quantidade} números foram lidos.");
                    Console.WriteLine($"    A soma deles é: {somatória}.");
                    Console.WriteLine($"    {pares} deles são pares.");
                    Console.ReadLine();
                        break;
                    case 5 or 05:
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Este algoritmo imprime a tabuado do 1 ao 10");
                    Console.WriteLine("    Por favor, digite o índice da tabuada: ");
                    int index = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"    {index} × {i} = {index * i}");
                    }
                    Console.ReadLine();
                        break;
                    case 6 or 06:
                    Console.Clear();
                    Console.WriteLine(@"



    Este algoritmo calcula a média de salários de uma empresa, pedindo ao 
    usuário a quantidade de funcionários, apresenta qual é o salário mais
    alto e o salário mais baixo.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n    Quantos funcionários tem a empresa?");
                    int employees = int.Parse(Console.ReadLine());
                    double wage, wageSum = 0;
                    double shortest = double.MaxValue, highest = double.MinValue;
                    string shortestsName = "", highestsName = "";
                    for (int i = 1; i <= employees; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Como se chama o {i}º funcionário?");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"\n\n\n\n    Qual é o salário de {name}?");
                        wage = int.Parse(Console.ReadLine());
                        wageSum += wage;
                        if (wage < shortest)
                        {
                            shortest = wage;
                            shortestsName = name;
                        }
                        if (wage > highest)
                        {
                            highest = wage;
                            highestsName = name;
                        }
                    }
                    Console.Clear();
                    double averageWage = wageSum / employees;
                    string salary = averageWage.ToString("C");
                    Console.WriteLine($"\n\n\n\n    A média dos salários é: {salary};");
                    Console.WriteLine($"    O salário mais alto é o de {highestsName};");
                    Console.WriteLine($"    O salário mais baixo é o de {shortestsName}.");
                    Console.ReadLine();
                        break;
                    case 7 or 07:
                    Console.Clear();
                    ulong last, first = 0, second = 1, next;
                    Console.WriteLine("\n\n\n\n    Este algoritmo escreve a sequência Fibonacci, no limite que desejar.");
                    Console.WriteLine("    Digite o número de termos que deseja gerar dentro da sequência:");
                    last = ulong.Parse(Console.ReadLine());
                    Console.WriteLine("    Sequência Fibonacci: ");
                    for (ulong k = 1; k < last; k++)
                    {
                        if (k <= 1)
                        {
                            Console.WriteLine("    " + k);
                        }
                        else
                        {
                            next = first + second;
                            first = second; // se esta linha e a de baixo forem trocadas,
                            second = next; // o algoritmo será de progressão geométrica.
                            Console.WriteLine("    " + next);
                        }
                    }
                    Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\n\n\n\n Desculpe-me, não entendi o que disse.\nPoderia repetir?");
                        break;
            }
                Console.Clear();
                Console.WriteLine(@"
 


    Deseja sair ou verificar outro exercício?

    Se deseja continuar, aperte [1]
    Se deseja encerrar, aperte [2]");
            int yerOrNo = int.Parse(Console.ReadLine());
            if (yerOrNo == 2)
            {
                break;
            }
        }while (true);
            break;
        default:
            Console.WriteLine("    Desculpa, eu não entendi. Poderia repetir?");
            break;
    }
    Console.Clear();
    Console.WriteLine("\n\n\n\n      Selecionar outra lista ou encerrar?");
    Console.WriteLine("      Se deseja encerrar, digite 'sair'.\n");
    string uscita = Console.ReadLine().ToLower();
    if (uscita == "sair")
    {
        break;
    }
    Console.Clear();
}