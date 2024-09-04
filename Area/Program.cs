using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool si = false;
            do
            {
                try
                {

                    Console.WriteLine("Hola :/ Que area quieres calcular?");
                    Console.WriteLine("1. Area de Circulo");
                    Console.WriteLine("2. Area de Triangulo");
                    Console.WriteLine("3. Area de Cuadrado");
                    Console.WriteLine("4. Area de Rectangulo");
                    Console.WriteLine("                         0.Salir");
                    byte opc = Convert.ToByte(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            si = true;
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese longitud del radio de su circulo (en cm)");
                            double radio = Convert.ToDouble(Console.ReadLine());
                            Calcular(radio);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese base y altura de su triangulo (en cm) \nBase: ");
                            double basetriangulo = Convert.ToDouble(Console.ReadLine());    
                            Console.WriteLine("Altura: ");
                            double altura = Convert.ToDouble(Console.ReadLine());
                            Calcular(altura, basetriangulo);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Ingrese en cm longitud del lado \nLado: ");
                            decimal lado = Convert.ToDecimal(Console.ReadLine());
                            Calcular(lado);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Ingrese en cm el ancho y largo del rectangulo \nAncho: ");
                            decimal ancho = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Largo: ");
                            decimal largo = Convert.ToDecimal(Console.ReadLine());
                            Calcular(ancho, largo);
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
            Console.WriteLine("so jajajajajajaja :(");
            Console.WriteLine("Error, ingrese informacion correctamente POR FAVOR ^^");
            Console.ReadKey();
            Console.Clear();
        }

        static void Calcular(double radio)
        {
            double area=(3.141592*(radio*radio));
            Console.WriteLine($"El area del circulo es de {area}");
            Console.ReadKey();
            Console.Clear();
        }

        static void Calcular(double altura, double basetriangulo)
        {
            double area = ((basetriangulo*altura)/2);
            Console.WriteLine($"El area del triangulo es de {area}");
            Console.ReadKey();
            Console.Clear();
        }

        static void Calcular(decimal lado)
        { 
            decimal area = (lado*lado);
            Console.WriteLine($"El area del cuadrado es de {area} cm2");
            Console.ReadKey();
            Console.Clear();
        }
        static void Calcular(decimal ancho, decimal largo)
        {
            decimal area = (ancho * largo);
            Console.WriteLine($"El area del rectangulo es de {area} cm2");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
