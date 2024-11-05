using System;
using System.Threading;

namespace Exercitando
{
    internal class Ex4
    {
        public void Exercicio4()
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

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
