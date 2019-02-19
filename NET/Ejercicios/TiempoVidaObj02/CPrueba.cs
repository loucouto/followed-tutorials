using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoVidaObj02
{
    class CPrueba:IDisposable
    {
        private int a;

        public CPrueba(int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", a);
        }

        public void Dispose()
        {
            Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}", a);
        }

        ~CPrueba()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aqui liberamos recursos no administrados");
            Console.Beep(600, 50);
        }

    }
}
