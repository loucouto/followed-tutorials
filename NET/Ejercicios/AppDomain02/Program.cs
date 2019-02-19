using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace AppDomain02
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain AD = AppDomain.CurrentDomain;

            Console.WriteLine("Nombre del dominio: {0}", AD.FriendlyName);
            Console.WriteLine("ID del dominio en el proceso: {0}", AD.FriendlyName);
            Console.WriteLine("Directorio base del dominio: {0}", AD.FriendlyName);

            if (AD.IsDefaultAppDomain() == true)
                Console.WriteLine("Es el de default");
            else
                Console.WriteLine("No es el de default");

            Console.WriteLine("--------");

            Assembly[] assemblies = AD.GetAssemblies();

            foreach (Assembly asm in assemblies)
            {
                Console.WriteLine("Nombre: {0}, version: {1}", asm.GetName().Name, asm.GetName().Version);
            }
        }
    }
}
