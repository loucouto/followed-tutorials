using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 55;

            bool par = numero.EsPar();

            Console.WriteLine("{0} es {1}", numero, par);

            double valor = 55.18;
            Console.WriteLine(valor.Dobletea());

            MiInt entero = new MiInt(7);
            entero.Sonido();

            Console.ReadLine();
        }
    }
}
