using System;

namespace Guia_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
             //Llamar metodos
            Principal op = new Principal();
            op.Bienvenida();
            Console.WriteLine();
            op.Valor();
            Console.WriteLine();
            op.Menu();
        }
    }
}
