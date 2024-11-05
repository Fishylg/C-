using System;

namespace Exercitando
{
    internal class MenuOpcoes
    {
        public void Opcoes()
        {
            int opcao;
            do
            {
                Menu();

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida! Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Ex1 ex1 = new Ex1();
                        ex1.Exercicio1();
                        break;

                    case 2:
                        Ex2 ex2 = new Ex2();
                        ex2.Exercicio2();
                        break;

                    case 3:
                        Ex3 ex3 = new Ex3();
                        ex3.Exercicio3();
                        break;

                    case 4:
                        Ex4 ex4 = new Ex4();
                        ex4.Exercicio4();
                        break;

                    case 5:
                        Ex5 ex5 = new Ex5();
                        ex5.Exercicio5();
                        break;

                    case 6:
                        Ex6 ex6 = new Ex6();
                        ex6.Exercicio6();
                        break;

                    case 7:
                        Extras1 extras1 = new Extras1();
                        extras1.Extra1();
                        break;

                    case 8:
                        Extras2 extras2 = new Extras2();
                        extras2.Extra2();
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

        private void Menu()
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("01 - Exercício 1: Verificar se o número é positivo, negativo ou zero");
            Console.WriteLine("02 - Exercício 2: Verificar maioridade");
            Console.WriteLine("03 - Exercício 3: Verificar se o número é par ou ímpar");
            Console.WriteLine("04 - Exercício 4: Encontrar o maior de três números");
            Console.WriteLine("05 - Exercício 5: Verificar se uma letra é vogal ou consoante");
            Console.WriteLine("06 - Exercício 6: Verificar situação da nota");
            Console.WriteLine("07 - Exercício 7: Celsius para Fahrenheit e vice-versa");
            Console.WriteLine("08 - Exercício 8: Três números e os exiba em ordem crescente");
            Console.WriteLine("00 - Sair\n");
            Console.Write("Escolha uma opção: ");
        }
    }
}
