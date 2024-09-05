using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formato
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
                    Console.WriteLine("Ingrese dia (dd)");
                    byte dia = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese mes (mm)");
                    byte mes = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese ano (aaaa)");
                    int anio = int.Parse(Console.ReadLine());

                    if (dia == 0 || dia > 31 || mes > 12 || anio == 0)
                    {
                        MensajeError();
                    }
                    else
                    {
                        Menu();
                        byte opc = byte.Parse(Console.ReadLine());
                        if (opc == 1) { CambiarFormato(dia, mes, anio); }
                        else if (opc == 2) { CambiarFormato(mes, anio, dia); }
                        else if (opc == 0) { continuar = true; }
                        else { MensajeError(); }
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
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opcion de formato");
            Console.WriteLine("1. dd/mm/aaaa");
            Console.WriteLine("2. mm/aaaa/dd");
            Console.WriteLine("0. Salir");

        }
        static void MensajeError()
        {
            Console.Clear();
            Console.WriteLine("Error, ingrese informacion correctamente POR FAVOR ^^");
            Console.ReadKey();
            Console.Clear();
        }
        static void CambiarFormato(byte dia, byte mes, int anio) 
        {
            Console.Clear();
            Console.WriteLine($"NUEVO FORMATO: {dia}/{mes}/{anio}");
            Console.ReadKey();
            Console.Clear();
        }
        static void CambiarFormato(byte mes, int anio, byte dia)
        {
            Console.Clear();
            Console.WriteLine($"NUEVO FORMATO: {mes}/{anio}/{dia}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
