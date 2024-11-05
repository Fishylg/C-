using System;
using System.Threading;

namespace Exercitando
{
    internal class Ex3
    {
        public void Exercicio3()
        {
            Console.Clear();
            Console.WriteLine("Exercício 3 - Verificar se o número é par ou ímpar");

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("O número é par.");
            else
                Console.WriteLine("O número é ímpar.");

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
