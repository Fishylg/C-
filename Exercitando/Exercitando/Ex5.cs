using System;
using System.Linq;
using System.Threading;

namespace Exercitando
{
    internal class Ex5
    {
        public void Exercicio5()
        {
            Console.Clear();
            Console.WriteLine("Exercício 5 - Verificar se uma letra é vogal ou consoante");

            Console.Write("Digite uma letra: ");
            char letra = char.Parse(Console.ReadLine().ToLower());

            if ("aeiou".Contains(letra))
                Console.WriteLine("A letra é uma vogal.");
            else
                Console.WriteLine("A letra é uma consoante.");

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
