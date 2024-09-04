using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Multiplicar
{
    public class Program
    {
        public static void Main(string[] args)
        {
        bool si = false;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese un numero entero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Tabla del {num}");
                    Multiplicar(num);
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
                    Console.WriteLine("Error de formato, intente de nuevo.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!si);
            

        }
        public static void Multiplicar(int n, int multiplicador=0)
        {
            if (multiplicador > 10)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
                Multiplicar(n, multiplicador+1);
                
            }


        }
            
    }
}
