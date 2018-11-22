using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de versiones1");
            Console.WriteLine("Control de versiones2");
            Console.WriteLine("Control de versiones3");
            Console.WriteLine("Control de versiones4");
            Console.WriteLine("Control de versiones5");
            Console.WriteLine("Control de versiones6");
            Console.WriteLine("Control de versiones7");
            Console.WriteLine("Probando control de versiones");

            Console.WriteLine("3 elevado a la 4 es igual a: {0}",potencia(3,4));
            try { 
            Console.WriteLine("-5 elevado a la 2 es igual a: {0}",potencia(-5,2));
            }catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }

            Console.WriteLine("2 elevado a la 5 es igual a: {0}",potencia(2,5));

            Console.ReadKey();
        }

        public static double potencia (double x, int y)
        {
            if (x <= 0)
            {
                throw new Exception("X debe ser positivo...");
            }
            if (y <= 0)
            {
                throw new Exception("Y debe ser positivo...");
            }

            double p = 1;
            for (int i = 1; i <= y; i++)
            {
                p = p * x;
            }
            return p;
        }
    }
}
