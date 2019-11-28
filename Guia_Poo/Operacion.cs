using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Poo
{
    class Operacion
    {
        //declarar global
        double Res;
        //Metodos con respectiva operacion
        public double Suma(Valores V)
        {
            Res = V.ValorA + V.ValorB;
            return Res;
        }

        public double Resta(Valores V)
        {
            Res = V.ValorA - V.ValorB;
            return Res;
        }

        public double Multiplicar(Valores V)
        {
            Res = V.ValorA * V.ValorB;
            return Res;

        }

        public double Division(Valores V)
        {
            Res = V.ValorA / V.ValorB;
            return Res;
        }
    }
}

