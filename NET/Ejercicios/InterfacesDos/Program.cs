using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDos
{
    class Program
    {
        static void Main(string[] args)
        {
            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RCB"), new CTelevisor("Filips")};
            IElectronico aparatoCreado = null;

            for (int n = 0; n < teles.Length; n++)
                Console.WriteLine(teles[n]);

            Console.WriteLine("---");

            CTelevisor miTV = new CTelevisor("Charp TV");
            CRadio miRadio = new CRadio("RCB Radio");

            Muestra(miRadio);
            Muestra(miTV);

            Console.WriteLine("---");

            aparatoCreado = CrearAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);
        }

        static void Muestra(IElectronico aparato)
        {
            aparato.Encender(true);

            if (aparato is CTelevisor)
                Console.WriteLine("El televisor es {0}", aparato);

            if (aparato is CRadio)
                Console.WriteLine("El radio es {0}", aparato);
        }

        static IElectronico CrearAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("Que deseas crear? 1-Tele, 2-Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1)
            {
                Console.WriteLine("Dame la marca de la tele");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Dame la marca del radio");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }

            return aparato;
        }
    }
}
