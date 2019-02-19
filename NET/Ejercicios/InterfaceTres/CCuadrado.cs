﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTres
{
    class CCuadrado: IArea, IPerimetro
    {
        private int lado;

        public CCuadrado(int pLado)
        {
            lado = pLado;
        }

        void IArea.Calcular()
        {
            Console.WriteLine("Calcular area = {0}", lado * lado);
        }

        void IPerimetro.Calcular()
        {
            Console.WriteLine("Calcular perimetro={0}", lado * 4);
        }
    }
}
