using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Practica_2
{
    public class Factorial
    {
        public static void Main()
        {
            bool si = false;

            do
            {
                try
                {
                    int num;
                    Console.WriteLine("Introduzca un número entero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su factorial es:{0}", Factorial(num));
                    Console.WriteLine("Continuar?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    if (opc == 2)
                    {
                        si = true;
                    }
                    Console.Clear();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Error, intente de nuevo");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (!si);
            long Factorial(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial(n - 1);
                }
            }

        }
    }
}
