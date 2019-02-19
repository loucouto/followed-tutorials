using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-O", 20);
            Random rnd = new Random();

            while(miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(rnd.Next(10));
                }
                catch(Exception e)
                {
                    Console.WriteLine("El mensaje: {0}", e.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
