using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Poo
{
    class Valores
    {
        //Encapsulacion de los valores

        private double id;
        private double valorA;
        private double valorB;

        public double ID
        {
            get { return id; }
            set { id = value; }
        }

        public double ValorA
        {
            get { return valorA; }
            set { valorA = value; }

        }

        public double ValorB
        {
            get { return valorB; }
            set { valorB = value; }
        }
    }
}
