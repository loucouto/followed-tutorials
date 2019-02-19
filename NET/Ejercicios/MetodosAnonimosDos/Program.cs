using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimosDos
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunto miPunto = new CPunto(5, 6);

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Estoy desde el metodo anonimo");
            };

            Console.WriteLine(miPunto.ToString());

            miPunto.mensaje();

            miPunto.mensaje += delegate ()
            {
                Console.WriteLine("Este es otro metodo anonimo");
            };

            miPunto.mensaje();

            Console.ReadLine();
        }

       
    }
}
