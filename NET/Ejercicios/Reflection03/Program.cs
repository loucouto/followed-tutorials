using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Reflection03
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = null;

            try
            {
                asm = Assembly.Load("Aritmetica");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if (asm != null)
            {
                Type mates = asm.GetType("Aritmetica.MisMates");

                try
                {
                    object obj = Activator.CreateInstance(mates, new object[] { 5, 3 });

                    Console.WriteLine("Tenemos instancia de {0}", obj);
                    MethodInfo suma = mates.GetMethod("suma");

                    PropertyInfo resultado = mates.GetProperty("R");

                    double r = 0;

                    suma.Invoke(obj, null);

                    r = (double)resultado.GetValue(obj);
                    Console.WriteLine("El resultado es {0}", r);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
