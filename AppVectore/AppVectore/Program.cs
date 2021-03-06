﻿using System;
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
            Console.WriteLine("LA NOTA 5 EQUIVALE A:  {0}", NotaEquivalente(5));
            vectorInicializar();


            Console.ReadKey();
        }

        public static void vectorInicializar()
        {
            int[] x=new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;
            //imprimir el vector
            Console.WriteLine("\nELEMENTOS DEL VECTOR\n===================\n");
            for(int i=0;i<8;i++)
            {
                Console.WriteLine("Elemento índice {0} --> {1} ", (i + 1), x[i]);
            }

            //sumatoria de los elementos del vector
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                suma = suma + x[i];
            }

            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("El promedio es  {0}", (double)suma/x.Length);


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

        public static String NotaEquivalente(double nota)
        {
            if (nota >= 0 && nota < 5)
                return "Suspenso";
            else if (nota >= 5 && nota < 6.5)
                return "Aprobado";
            else if (nota >= 6.5 && nota < 8.5)
                return "Notable";
            else if (nota >= 8.5 && nota < 10)
                return "Sobresaliente";
            else if (nota == 10)
                return " MATRICULA DE HONOR";
            else
                return " nota fuera de rango"; 

        }
    }
}
