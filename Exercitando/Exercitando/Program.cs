using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("===============================================================================================================");
                Console.WriteLine("\r\n███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░\r\n██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗\r\n█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║\r\n██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║\r\n███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝\r\n╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░     ");
                Console.WriteLine("===============================================================================================================\n");
                Console.WriteLine("Autor: Ryan Lima Germano\n");

                Console.WriteLine("Opções:");
                Console.WriteLine("01 - Exercício 1: Verificar se o número é positivo, negativo ou zero");
                Console.WriteLine("02 - Exercício 2: Verificar maioridade");
                Console.WriteLine("03 - Exercício 3: Verificar se o número é par ou ímpar");
                Console.WriteLine("04 - Exercício 4: Encontrar o maior de três números");
                Console.WriteLine("05 - Exercício 5: Verificar se uma letra é vogal ou consoante");
                Console.WriteLine("06 - Exercício 6: Verificar situação da nota");
                Console.WriteLine("00 - Sair\n");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 6:
                        Exercicio6();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }

        static void Exercicio1()
        {
            Console.Clear();
            Console.WriteLine("Exercício 1 - Verificar se o número é positivo, negativo ou zero");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
                Console.WriteLine("O número é positivo.");
            else if (numero < 0)
                Console.WriteLine("O número é negativo.");
            else
                Console.WriteLine("O número é zero.");
        }

        static void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Exercício 2 - Verificar maioridade");

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Você é maior de idade.");
            else
                Console.WriteLine("Você é menor de idade.");
        }

        static void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Exercício 3 - Verificar se o número é par ou ímpar");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");
        }

        static void Exercicio4()
        {
            Console.Clear();
            Console.WriteLine("Exercício 4 - Encontrar o maior de três números");

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            int maior = num1;

            if (num2 > maior) maior = num2;
            if (num3 > maior) maior = num3;

            Console.WriteLine("O maior número é: " + maior);
        }

        static void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("Exercício 5 - Verificar se uma letra é vogal ou consoante");

            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine().ToLower());

            if ("aeiou".Contains(letra))
                Console.WriteLine("A letra é uma vogal.");
            else
                Console.WriteLine("A letra é uma consoante.");
        }

        static void Exercicio6()
        {
            Console.Clear();
            Console.WriteLine("Exercício 6 - Verificar situação da nota");

            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7)
                Console.WriteLine("Aluno aprovado.");
            else if (nota >= 5 && nota < 7)
                Console.WriteLine("Aluno em recuperação.");
            else
                Console.WriteLine("Aluno reprovado.");
        }
    }
}

