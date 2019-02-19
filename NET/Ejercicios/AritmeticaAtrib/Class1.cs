using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmeticaAtrib
{
    [Datos("Mi clase  de matematicas")]
    public class MisMates
    {
        private double a;
        private double b;
        private double r;

        public MisMates(double pA, double pB)
        {
            a = pA;
            b = pB;
            r = 0;
        }

        public double R { get { return r; } }

        public double suma()
        {
            r = a + b;
            return r;
        }

        public double resta()
        {
            r = a - b;
            return r;
        }

        public double multi()
        {
            r = a * b;
            return r;
        }

        public double div()
        {
            r = a / b;
            return r;
        }
    }

    [Datos("Clase de prueba 1")]
    class CPrueba
    {
        public CPrueba()
        {
            Console.WriteLine("Version 1");
        }
    }

    [Datos("Clase de prueba 2")]
    class CPrueba2
    {
        public CPrueba2()
        {
            Console.WriteLine("Version 2");
        }
    }

    public sealed class DatosAttribute : System.Attribute
    {
        string dato = "";
        public string Dato { get { return dato; } set { dato = value; } }

        public DatosAttribute()
        {
        }

        public DatosAttribute(string pDato)
        {
            dato = pDato;
        }
    }
}
