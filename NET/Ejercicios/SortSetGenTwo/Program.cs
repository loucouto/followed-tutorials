using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SortSetGenTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>()
            {new CPunto(4,55), new CPunto(17,22)};

            puntos.CollectionChanged += puntos_CollectionChanged;
            puntos.Add(new CPunto(2, 3));

            CPunto miPunto = new CPunto(5, 5);

            puntos.Add(miPunto);

            puntos.Remove(miPunto);

            Console.ReadLine();
        }

        static void puntos_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("El eventos es {0}", e.Action);

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (CPunto p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (CPunto p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }


    }
}
