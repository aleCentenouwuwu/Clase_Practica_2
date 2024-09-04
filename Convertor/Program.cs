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
            // errores: por alguna razon el programa termina cuando no hay nada que lo indique
            // LOS PARAMETROS AHGGGGGGGGGGGGGGGGGGGGGG
            do
            {
                try
                {
                    Console.WriteLine("Hola, que queres convertir a otra unidad de medida hoy? :o"); // pense en que el usuario eligiera, x ejem.
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
                            Console.WriteLine("Ingrese centimetros a convertir");
                            double Centimetros = Convert.ToDouble(Console.ReadLine());
                            Convertir(Centimetros);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese kilometros a convertir");
                            int Kilometros = Convert.ToInt32(Console.ReadLine());
                            Convertir(Kilometros);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese metros a convertir");
                            // UInt16 Metros = Convert.ToUInt16(Console.ReadLine());
                            //  Convertir(Metros);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Ingrese centimetros a convertir");
                            //    UInt32 Centi = Convert.ToUInt32(Console.ReadLine());
                            //  Convertir(Centi);
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
            } while (!si);
        }
        static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("jajajajajajaja :(");
            Console.WriteLine("Error, ingrese informacion correctamente POR FAVOR ^^");
            Console.ReadKey();
            Console.Clear();
        }

        static void Convertir(double centimetro)
        {
            double milimetro = centimetro * 100;
            Console.WriteLine($"{centimetro} centimetros son {milimetro} milimetros.");
            Console.ReadKey();
            Console.Clear();
        }

        static void Convertir(int kilometros) //me rindo brother, ya no me da la cabeza
        {
            int millas = kilometros / 1609;
            Console.WriteLine($"{kilometros} kilometros son {millas} millas.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Convertir(uint metros)
        {
            uint kilometros = metros / 1000;
            Console.WriteLine($"{metros} metros son {kilometros} kilometros.");
            Console.ReadKey();
            Console.Clear();
        }
      //'  static void Convertir(int centi)
        //{
            //pulgadas = centi / 2.54; // QUEEEEEEEEEEEEEEEEEEEEEEEEEEEE
          //  Console.ReadKey();
           // Console.Clear();
        //}
    }
}
