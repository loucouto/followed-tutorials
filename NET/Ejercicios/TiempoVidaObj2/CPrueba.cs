using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoVidaObj2
{
    class CPrueba
    {
        private int a;
        private bool usoDispose = false;

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
            //Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}", a);
            GC.SuppressFinalize(this);
        }

        ~CPrueba()
        {
           // Console.ForegroundColor = ConsoleColor.Red;

            GC.SuppressFinalize(this);
          //  Console.Beep(600, 50);
        }

        public void Limpieza()
        {
            if (usoDispose == false)
            {
                Console.WriteLine("Aqui liberamos recursos no administrados");
            }
            usoDispose = true;
        }

    }
}
