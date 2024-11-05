using System;
using System.Threading;
namespace Exercitando
{
    internal class Ex1
    {
        public void Exercicio1()
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

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
