using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionDelegado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string m = "Hola a todos";

            Action<string, int> delAction = new Action<string, int>(RepiteMensaje);

            delAction(m, n);

        }

        static void RepiteMensaje(string pMensaje, int pVeces)
        {
            int n = 0;
            for (n = 0; n < pVeces; n++)
                Console.WriteLine(pMensaje);

        }
    }
}
