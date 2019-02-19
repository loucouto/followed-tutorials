using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones03
{
    class Caldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public int Temperatura { get { return tempActual; } set { tempActual = value; } }
        public string Marca { get { return marca; } set { marca = value; } }
        public bool Funciona { get { return funciona; } set { funciona = value; } }

        public Caldera(string pMarca, int pTemp)
        {
            tempActual = pTemp;
            marca = pMarca;
        }

        public void Trabajar(int pAumento)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} esta descompuesta", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", marca, tempActual);

                if (tempActual > tempMax)
                {
                    Console.WriteLine("{0} supero la temperatura,  tiene {1}", tempActual);
                    tempActual = tempMax;
                    funciona = false;

                    CalderaExcepcion ex = new CalderaExcepcion(string.Format("La caldera {0} se ha sobrecalentado", marca), "Ha trabajado demasiado tiempo", DateTime.Now);
                    ex.HelpLink = "http://www.nicosio.com";
                    throw ex;
                }
            }
        }
    }

    /* public class CalderaExcepcion : ApplicationException
     {
         private string mensaje = "";
         private DateTime momento;
         private string causa;

         public DateTime Momento { get { return momento; } set { momento = value; } }
         public string Causa { get { return causa; } set { causa = value; } }

         public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento) :
             base(pMensaje)
         {
             causa = pCausa;
             momento = pMomento;
         }

         public override string Message
         {
             get
             {
                 return string.Format("Mensaje de la excepcion=> {0}", mensaje);
             }
         }
     }*/

    [Serializable]
    public class CalderaExcepcion : ApplicationException
    {
        public CalderaExcepcion() { }
        public CalderaExcepcion(string pMensaje) : base(pMensaje) { }
        public CalderaExcepcion(string pMensaje, System.Exception inner) :
            base(pMensaje, inner){ }
        protected CalderaExcepcion(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        //Aqui propiedades adicionales
        private DateTime momento;
        private string causa;

        public DateTime Momento { get { return momento; } set { momento = value; } }
        public string Causa { get { return causa; } set { causa = value; } }

        public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
            :base(pMensaje)
        {
            causa = pCausa;
            momento = pMomento;
        }

    }
}