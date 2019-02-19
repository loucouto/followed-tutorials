using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-O", 20);

            /*for (int i = 0; i < 10; i++)
                miCaldera.Trabajar(20);*/

            try
            {
                for (int i = 0; i < 10; i++)
                    miCaldera.Trabajar(20);

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("\nSucedio la excepcion");
                Console.WriteLine("En este metodo: {0}", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}", e.Message);
                Console.WriteLine("Fuente: {0}", e.Source);

                Console.WriteLine("Clase donde ocurrio: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);

                Console.WriteLine("Stack: {0}", e.StackTrace);

                Console.WriteLine("Mostramos los datos propios");

                if (e.Data != null)
                {
                    foreach (DictionaryEntry dato in e.Data)
                        Console.WriteLine("-> {0} -> {1}", dato.Key, dato.Value);
                }

                Console.ReadLine();
            }
        }
    }
}
