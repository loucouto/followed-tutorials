using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CTelevisor miTele = new CTelevisor("Sharpy");
            CPelota miPelota = new CPelota("Grande");
            IElectronico objeto = null;

            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)miTele;
                objeto.Encender(true);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)miPelota;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("----");

            Console.WriteLine("Probamos la tele");
            objeto = miTele as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");
            objeto = miPelota as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No impleta IElectronico");

            Console.WriteLine("------");

            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                miTele.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");

            if (miPelota is IElectronico)
                Console.WriteLine("Wow tienes una pelota electronica");
            else
                Console.WriteLine("No implementa IElectronico");
        }
    }
}
