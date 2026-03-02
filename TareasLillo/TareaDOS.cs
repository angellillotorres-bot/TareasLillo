using System;
using System.Collections.Generic;
using System.Text;

namespace TareasLillo
{
    internal class TareaDOS
    {
        static void Main()
        {
            int cantidadPersonas = SolicitarCantidadPersonas();

            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();

            RegistrarPersonas(cantidadPersonas, nombres, edades);
            MostrarResultados(cantidadPersonas, nombres, edades);

            Console.WriteLine("\nPrograma finalizado.");
        }

        // FUNCIÓN 1
        static int SolicitarCantidadPersonas()
        {
            int cantidad;

            while (true)
            {
                Console.Write("Ingrese la cantidad de personas a registrar: ");
                if (int.TryParse(Console.ReadLine(), out cantidad) && cantidad >= 1)
                {
                    return cantidad;
                }
                else
                {
                    Console.WriteLine("⚠ Valor inválido.");
                }
            }
        }

        // PROCEDIMIENTO
        static void RegistrarPersonas(int cantidad, List<string> nombres, List<int> edades)
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nPersona {i + 1}");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                int edad;
                while (true)
                {
                    Console.Write("Edad: ");
                    if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                    {
                        edades.Add(edad);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("⚠ Edad inválida.");
                    }
                }
            }
        }

        // FUNCIÓN 2
        static string DeterminarMayorDeEdad(int edad)
        {
            if (edad >= 18)
                return "Es mayor de edad.";
            else
                return "Es menor de edad.";
        }

        static void MostrarResultados(int cantidad, List<string> nombres, List<int> edades)
        {
            if (cantidad == 1)
            {
                Console.WriteLine("\n=== Resultado ===");
                Console.WriteLine($"Nombre: {nombres[0]}");
                Console.WriteLine($"Edad: {edades[0]}");
                Console.WriteLine(DeterminarMayorDeEdad(edades[0]));
            }
            else
            {
                List<string> mayores = new List<string>();
                List<string> menores = new List<string>();

                Console.WriteLine("\n=== Lista general ===");

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"{nombres[i]} - {edades[i]} años");

                    if (edades[i] >= 18)
                        mayores.Add($"{nombres[i]} - {edades[i]} años");
                    else
                        menores.Add($"{nombres[i]} - {edades[i]} años");
                }

                if (mayores.Count > 0)
                {
                    Console.WriteLine("\n=== Mayores de edad ===");
                    foreach (string persona in mayores)
                        Console.WriteLine(persona);
                }

                if (menores.Count > 0)
                {
                    Console.WriteLine("\n=== Menores de edad ===");
                    foreach (string persona in menores)
                        Console.WriteLine(persona);
                }
            }
        }
    }
}