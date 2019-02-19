using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection02
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = null;

            try
            {
                asm = Assembly.Load("AritmeticaDos");
                EncuentraTipos(asm);
            }
            catch
            {
                Console.WriteLine("Assembly no encontrado");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void EncuentraTipos(Assembly asm)
        {
            Console.WriteLine("Los tipos encontrados en {0} son:", asm.FullName);

            Type[] tipos = asm.GetTypes();

            foreach (Type t in tipos)
                Console.WriteLine(t);
          
        }
    }
}
