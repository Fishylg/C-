using System;
using System.Threading;

namespace Exercitando
{
    internal class Ex6
    {
        public void Exercicio6()
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

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
