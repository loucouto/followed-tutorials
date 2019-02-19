using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Type t = Type.GetType("System.Console");

                CaracteristicasTipo(t);
                EncuentraCampos(t);
                EncuentraPropiedades(t);
                EncuentraMetodos(t);
                EncuentraInterfaces(t);
            }
            catch
            {
                Console.WriteLine("Verificar el tipo");
            }
        }

        public static void CaracteristicasTipo(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tiene son:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clase base: {0}", t.BaseType);
            Console.WriteLine("Es una clase: {0}", t.IsClass);
            Console.WriteLine("Abstracta: {0}", t.IsAbstract);
            Console.WriteLine("Sellada: {0}", t.IsSealed);
            Console.WriteLine("Generica: {0}", t.IsGenericTypeDefinition);
        }

        public static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        public static void EncuentraPropiedades(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las propiedades encontradas son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from p in t.GetProperties() select p.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        public static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los metodos encontados son:");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void EncuentraInterfaces(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las interfaces encontradas son:");
            Console.ForegroundColor = ConsoleColor.White;

            var nombres = from i in t.GetInterfaces() select i;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }
    }
}
