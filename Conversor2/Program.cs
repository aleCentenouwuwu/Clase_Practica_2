using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_No2
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
                    Menu();
                    byte opc = byte.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 0:
                            si = true;
                            break;
                        case 1:
                            TemperaturaMenu();
                            break;
                        case 2:
                            DistanciaMenu();
                            break;
                        case 3:
                            TiempoMenu();
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
                catch (OverflowException)
                {
                    MensajeError();
                }
                catch (Exception)
                {
                    MensajeError();
                }
            } while (!si);
        }
        static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error, ingrese la informacion correctamente");
            Console.ReadKey();
            Console.Clear();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1. Convertir temperatura");
            Console.WriteLine("2. Convertir distancia");
            Console.WriteLine("3. Convertir tiempo");
            Console.WriteLine("0. Salir");

        }

        static void TemperaturaMenu()
        {
            Console.Clear();
            Console.WriteLine("Que desea convertir?");
            Console.WriteLine("1. Celsius a Farenheit");
            Console.WriteLine("2. Farenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("0. Volver");
            byte opcion = byte.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese temmperatura en celsius");
                    double celsius = double.Parse(Console.ReadLine());
                    double farenheit = ((celsius * 1.8) + 32);
                    Console.WriteLine($"{celsius} grados Celsius son {farenheit} grados Farenheit");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese su temoeratura en Farenheit");
                    double Farenheit = double.Parse(Console.ReadLine());
                    double Celsius = (Farenheit - 32) * 0.5555;
                    Console.WriteLine($"{Farenheit} grados Farenheit son {Celsius} grados Celsius");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese su temperatura en celsius");
                    double GradosCelsius = double.Parse(Console.ReadLine());
                    double Kelvin = GradosCelsius + 273.15;
                    Console.WriteLine($"{GradosCelsius} grados Celsius son {Kelvin} Kelvin");
                    Console.ReadKey();
                    break;
            }
        }
        static void DistanciaMenu()
        {
            Console.Clear();
            Console.WriteLine("Que distancia desea convertir?");
            Console.WriteLine("1. Centimetros a milimetros");
            Console.WriteLine("2. Kilometros a Millas");
            Console.WriteLine("3. metros a Kilometros");
            Console.WriteLine("4. Centimetros a pulgadas");
            Console.WriteLine("0.Volver atras");
            byte opc = Convert.ToByte(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese centímetros a convertir");
                    int centimetros = Convert.ToInt32(Console.ReadLine());
                    double milimetros = centimetros * 10;
                    Console.WriteLine($"{centimetros} centímetros son {milimetros} milímetros.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese kilómetros a convertir");
                    double kilometros = Convert.ToDouble(Console.ReadLine());
                    double millas = kilometros / 1.609;
                    Console.WriteLine($"{kilometros} kilómetros son {millas} millas.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese metros a convertir");
                    int metros = Convert.ToInt32(Console.ReadLine());
                    double km = metros / 1000;
                    Console.WriteLine($"{metros} metros son {km} kilómetros.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Ingrese centímetros a convertir a pulgadas");
                    double centi = Convert.ToDouble(Console.ReadLine());
                    double pulgadas = centi / 2.54;
                    Console.WriteLine($"{centi} centímetros son {pulgadas} pulgadas.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    MensajeError();
                    break;
            }
        }
        static void TiempoMenu()
        {
            Console.Clear();
            Console.WriteLine("Que desea convertir?");
            Console.WriteLine("1. Segundos a minutos");
            Console.WriteLine("2. Minutos a horas");
            Console.WriteLine("3. Horas a dias");
            Console.WriteLine("0. Volver");
            byte opc = Convert.ToByte(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese segundos a convertir");
                    int segundos = Convert.ToInt32(Console.ReadLine());
                    int minutos = segundos / 60;
                    Console.WriteLine($"{segundos} segundos son {minutos} minutos.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese minutos a convertir. ");
                    int min = Convert.ToInt32(Console.ReadLine());
                    int hora = min / 60;
                    Console.WriteLine($"{min} minutos son {hora} horas.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese horas a convertir");
                    int hr = Convert.ToInt32(Console.ReadLine());
                    int dia = hr / 24;
                    Console.WriteLine($"{hr} horas son {dia} dias.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    MensajeError();
                    break;

            }

        }
    }
}