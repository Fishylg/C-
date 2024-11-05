using System;
using System.Threading;

namespace Exercitando
{
    internal class Ex2
    {
        public void Exercicio2()
        {
            Console.Clear();
            Console.WriteLine("Exercício 2 - Verificar maioridade");

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine("Você é maior de idade.");
            else
                Console.WriteLine("Você é menor de idade.");

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
