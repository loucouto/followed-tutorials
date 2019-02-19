using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var miCompu = new { Procesador = "i7", Memoria = 16, Graficos = "intel" };

            Console.WriteLine(miCompu);
            Console.WriteLine("la compu tiene {0} de memoria", miCompu.Memoria);

            miCompu.Graficos = "nvidia";
        }
    }
}
