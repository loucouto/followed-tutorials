using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones04
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-O", 20);

            try
            {
                miCaldera.Trabajar(-10);
            }
            catch (CalderaExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Este es el codigo comun en finally");
            }

        }
    }
}
