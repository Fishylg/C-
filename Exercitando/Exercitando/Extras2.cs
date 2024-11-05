using System;
using System.Threading;

namespace Exercitando
{
    internal class Extras2
    {
        public void Extra2()
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int num3 = int.Parse(Console.ReadLine());

            int menor, meio, maior;

            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
                if (num2 <= num3)
                {
                    meio = num2;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num2;
                }
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
                if (num1 <= num3)
                {
                    meio = num1;
                    maior = num3;
                }
                else
                {
                    meio = num3;
                    maior = num1;
                }
            }
            else
            {
                menor = num3;
                if (num1 <= num2)
                {
                    meio = num1;
                    maior = num2;
                }
                else
                {
                    meio = num2;
                    maior = num1;
                }
            }

            Console.WriteLine("Ordem crescente: " + menor + ", " + meio + ", " + maior);
            
            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
