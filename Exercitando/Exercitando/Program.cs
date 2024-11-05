using System;

namespace Exercitando
{
    class Program
    {
        static void Main(string[] args)
        {
            Nome Autor = new Nome();
            Autor.Autor();

            MenuOpcoes menu = new MenuOpcoes();
            menu.Opcoes();
        }
    }
}
