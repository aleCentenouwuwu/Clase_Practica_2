using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool si = true;
            do
            {
                try
                {
                    Console.WriteLine("Hola, que queres convertir a otra unidad de medida hoy? :o");
                    Console.WriteLine("1. Centimetros a milimetros");
                    Console.WriteLine("2. Kilometros a Millas");
                    Console.WriteLine("3. metros a Kilometros");
                    Console.WriteLine("4. Centimetros a pulgadas");
                    Console.WriteLine("                                                  0. Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            si = false;
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese centímetros a convertir");
                            int centimetros = Convert.ToInt32(Console.ReadLine());
                            Convertir(centimetros);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese kilómetros a convertir");
                            double kilometros = Convert.ToDouble(Console.ReadLine());
                            Convertir(kilometros);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese metros a convertir");
                            int metros = Convert.ToInt32(Console.ReadLine());
                            Convertir2(metros);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Ingrese centímetros a convertir a pulgadas");
                            double centi = Convert.ToDouble(Console.ReadLine());
                            Convertir2(centi);
                            break;
                        default:
                            MensajeError();
                            break;
                    }
                }
                catch (FormatException)
                {
                    MensajeError();
                }
            } while (si);
        }
        static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error, ingrese informacion correctamente POR FAVOR ^^");
            Console.ReadKey();
            Console.Clear();
        }

        static void Convertir(int centimetros)
        {
            double milimetros = centimetros * 10;
            Console.WriteLine($"{centimetros} centímetros son {milimetros} milímetros.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Convertir(double kilometros)
        {
            double millas = kilometros / 1.609;
            Console.WriteLine($"{kilometros} kilómetros son {millas} millas.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Convertir2(int metros)
        {
            double kilometros = metros / 1000;
            Console.WriteLine($"{metros} metros son {kilometros} kilómetros.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Convertir2(double centimetros)
        {
            double pulgadas = centimetros / 2.54;
            Console.WriteLine($"{centimetros} centímetros son {pulgadas} pulgadas.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
