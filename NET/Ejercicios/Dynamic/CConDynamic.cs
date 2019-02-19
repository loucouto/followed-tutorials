using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class CConDynamic
    {
        private dynamic atributo;

        public dynamic Propiedad
        {
            get { return atributo; }
            set { atributo = value; }
        }

        public void imprime()
        {
            Console.WriteLine(atributo);
        }

        public void recibe(dynamic parametro)
        {
            Console.WriteLine("Recibi {0}", parametro);
        }

        public dynamic regresa(int a)
        {
            if (a < 0)
                return 5;
            else
                return "positivo";
        }
    }
}
