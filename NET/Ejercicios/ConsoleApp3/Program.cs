using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain dAD = AppDomain.CurrentDomain;

            dAD.AssemblyLoad += handlerCarga;
            dAD.ProcessExit += handlerDescarga;

            ListaAssemblies(dAD);

            AppDomain nuevoAD = AppDomain.CreateDomain("NuestroAppDomain");

            try
            {
                nuevoAD.Load("Aritmetica");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

            ListaAssemblies(nuevoAD);
            AppDomain.Unload(nuevoAD);
        }

        private static void ListaAssemblies(AppDomain pAd)
        {
            var assemblies = from asm in pAd.GetAssemblies() orderby asm.GetName().Name select asm;

            Console.WriteLine("Assemblies encontrados en {0}", pAd.FriendlyName);

            foreach (var asm in assemblies)
            {
                Console.WriteLine("Nombre : {0}, version {1}", asm.GetName().Name, asm.GetName().Version);
            }
        }

        public static void handlerCarga(System.Object o, AssemblyLoadEventArgs s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Se cargo {0}", s.LoadedAssembly.GetName().Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void handlerDescarga(System.Object o, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Se descargo el AppDomain");
        }
    }
}
