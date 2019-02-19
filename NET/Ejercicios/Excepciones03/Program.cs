using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones03
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-O", 20);

            try
            {
                miCaldera.Trabajar(-10);
            }
            catch (CalderaExcepcion e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Momento);
                Console.WriteLine(e.Causa);
            }
         
        }
    }

    
}
