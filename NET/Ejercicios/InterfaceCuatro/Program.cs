﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            CSuma miSuma = new CSuma();

            miSuma.Calculo(5, 3);

            miSuma.MostrarDatos();
        }
    }
}
