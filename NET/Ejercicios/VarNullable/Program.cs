using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = "Hola a todos";
            var c = 15.689;
            var d = false;
            var f = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("f es {0}->{1}", f.GetType().Name,f);

            Console.WriteLine("------------------");

            int? dato = 5;
            Console.WriteLine("dato {0}", dato);
            dato = null;
            Console.WriteLine("dato {0}", dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine(precio);

            precio = null;

            if (precio.HasValue)
                Console.WriteLine("Tiene valor {0}", precio.Value);
            else
                Console.WriteLine("No tiene valor");

            double? numero = asignador() ?? 5.55;
            Console.WriteLine(numero);

            Console.ReadLine();
        }

        public static double? asignador()
        {
            return 4.5;
        }
    }
}
