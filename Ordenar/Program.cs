using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = false;
            do
            {
                try
                {
                    Console.WriteLine("Que desea ordenar hoy?");
                    Console.WriteLine("1. Numeros");
                    Console.WriteLine("2. Palabras por orden alfabetico");
                    Console.WriteLine("0. Salir");
                    byte opc = byte.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 0: 
                            continuar = true; 
                            break;
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Cuantos numeros desea agregar?");
                            int cantidadNumeros = int.Parse(Console.ReadLine());
                            int[] numeros = new int[cantidadNumeros];

                            for (int i = 0; i < cantidadNumeros; i++)
                            {
                                Console.WriteLine($"Ingrese el número {i + 1}:");
                                numeros[i] = int.Parse(Console.ReadLine());
                            }
                            Ordenar(numeros);
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Cuantas palabras desea agregar?");
                            int cantidadPalabras = int.Parse(Console.ReadLine());
                            string[] palabras = new string[cantidadPalabras];

                            for (int i = 0; i < cantidadPalabras; i++)
                            {
                                Console.WriteLine($"Ingrese la palabra {i + 1}:");
                                palabras[i] = Console.ReadLine();
                            }
                            Ordenar(palabras);
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
                catch (Exception)
                {
                    MensajeError();
                }
            } while (!continuar);
        }
        static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error, ingrese informacion correctamente POR FAVOR ^^");
            Console.ReadKey();
            Console.Clear();
        }
        static void Ordenar(int[] numeros)
        {
            Array.Sort(numeros);
            Console.Clear();
            Console.WriteLine("Números ordenados de menor a mayor:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void Ordenar(string[] palabras)
        {
            Array.Sort(palabras);
            Console.Clear();
            Console.WriteLine("Palabras ordenadas alfabéticamente:");
            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine(palabras[i]);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
