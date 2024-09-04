using System;

namespace Fibonnaci
{
    internal class Program
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
                    Console.WriteLine($"Serie de Fibonacci hasta {num}:");
                    for (int i = 0; i <= num; i++)
                    {
                        Console.Write(Fibonacci(i) + " ");
                    }
                    Console.WriteLine();
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
        }
        public static long Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
