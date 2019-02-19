using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atributos03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.Load("AritmeticaAtributos");

                Type datoAt = asm.GetType("AritemticaAtributos.DatosAttribute");

                PropertyInfo datoProp = datoAt.GetProperty("Dato");

                Type[] tipos = asm.GetTypes();

                foreach (Type t in tipos)
                {
                    object[] objetos = t.GetCustomAttributes(datoAt, false);

                    foreach (object obj in objetos)
                    {
                        Console.WriteLine("{0}, {1}", t.Name, datoProp.GetValue(obj, null));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
