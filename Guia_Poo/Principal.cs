using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Poo
{
    class Principal
    {
        //Instanciar el valor V
        Valores V = new Valores();

        public void Bienvenida()
        {
            Console.WriteLine("Bienvenido");
            Console.ReadKey();

        }

        public void Menu()
        {
            //Operaciones que contiene
            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Dividir");
            Console.WriteLine("Salir");

            double Res;
            Operacion op = new Operacion();
            int n = Convert.ToInt32(Console.ReadLine());

            //Realizar el menu con switch
            switch (n)
            {
                case 1:
                    Res = op.Suma(V);
                    Console.WriteLine("La respues es:" + Res);
                    Console.ReadKey();
                    Menu();
                    break;

                case 2:
                    Res = op.Resta(V);
                    Console.WriteLine("La respues es:" + Res);
                    Console.ReadKey();
                    Menu();
                    break;

                case 3:
                    Res = op.Multiplicar(V);
                    Console.WriteLine("La respues es:" + Res);
                    Console.ReadKey();
                    Menu();
                    break;


                case 4:
                    Res = op.Division(V);
                    Console.WriteLine("La respues es:" + Res);
                    Console.ReadKey();
                    Menu();
                    break;

                case 5:
                    Console.WriteLine("Gracias por usar la mejor calculadora del mundo ");
                    Console.ReadKey();
                    Environment.Exit(0);
                    Console.ReadKey();
                    break;

                //Ponemos un default en caso de meter otro valor
                default:
                    Console.WriteLine("Introduzca uno de los 5 numeros");
                    Menu();
                    break;
            }
        }


        public void Valor()
        {

            Console.WriteLine("Ingrese el primer valor:");

            V.ValorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("  ");

            Console.WriteLine("Ingrese el segundo valor");

            V.ValorB = Convert.ToDouble(Console.ReadLine());
        }

    }
}
