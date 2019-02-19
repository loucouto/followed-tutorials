using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            var procesos = from proc in Process.GetProcesses() orderby proc.Id select proc;

            foreach (var proceso in procesos)
            {
                Console.WriteLine("PID: {0}, Nombre {1}", proceso.Id, proceso.ProcessName);
            }

            Console.WriteLine("--------");

            Process miProceso = null;
            int pid = 12172;

            try
            {
                miProceso = Process.GetProcessById(pid);
                Console.WriteLine("PID: {0}, Nombre {1}", miProceso.Id, miProceso.ProcessName);

                ProcessThreadCollection hilos = miProceso.Threads;

                foreach (ProcessThread hilo in hilos)
                {
                    Console.WriteLine("ID del hilo: {0}, Inicio: {1}, Prioridad: {2}", hilo.Id, hilo.StartTime, hilo.PriorityLevel);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("------");

           /* Process otroProceso = null;

            try
            {
                otroProceso = Process.Start("chrome.exe", "www.nicosio.com");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Oprime una tecla para continuar");
            Console.ReadLine();

            try
            {
                otroProceso.Kill();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
