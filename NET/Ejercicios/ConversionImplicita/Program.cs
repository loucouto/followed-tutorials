using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            CComplejo im1 = new CComplejo(2, 3);

            CReal real2 = (CReal)im1;
            Console.WriteLine(real2);

            CReal r3 = new CReal(3.5);

            CComplejo im2 = r3;

            Console.WriteLine(im2);
        }
    }
}
