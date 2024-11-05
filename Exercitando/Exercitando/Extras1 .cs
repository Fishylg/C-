using System;
using System.Threading;

namespace Exercitando
{
    internal class Extras1
    {
        public void Extra1()
        {
            Console.WriteLine("Conversão de Temperatura:");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.Write("Digite a temperatura em Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C é equivalente a {fahrenheit}°F");
            }
            else if (escolha == 2)
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine(fahrenheit + " °F é equivalente a " + celsius + " °C");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Thread.Sleep(1000);

            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
