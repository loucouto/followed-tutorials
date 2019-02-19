using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic texto = "hola";

            int n = texto.Length;

            texto.ToUpper();

            Console.WriteLine("{0}, {1}", n, texto);

            dynamic texto2 = "Nicosio";

            try
            {
                n = texto2.Length;
                texto2.ToUpper();
                Console.WriteLine("{0}, {1}", n, texto2);
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
        }
    }
}
