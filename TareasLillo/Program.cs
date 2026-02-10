
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int cantidadPersonas;

            // Solicitar cantidad de personas
            while (true)
            {
                Console.Write("Ingrese la cantidad de personas a registrar: ");
                if (int.TryParse(Console.ReadLine(), out cantidadPersonas) && cantidadPersonas >= 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("⚠ Valor inválido. Ingrese un número entero mayor o igual a 1.");
                }
            }

            // Listas para almacenar datos
            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();

            // Registro de personas
            for (int i = 0; i < cantidadPersonas; i++)
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
                        Console.WriteLine("⚠ Edad inválida. Ingrese un número válido.");
                    }
                }
            }

            // Caso especial: una sola persona
            if (cantidadPersonas == 1)
            {
                Console.WriteLine("\n=== Resultado ===");
                Console.WriteLine($"Nombre: {nombres[0]}");
                Console.WriteLine($"Edad: {edades[0]}");

                if (edades[0] >= 18)
                    Console.WriteLine("Es mayor de edad.");
                else
                    Console.WriteLine("Es menor de edad.");
            }
            else
            {
                // Caso general: dos o más personas
                List<string> mayores = new List<string>();
                List<string> menores = new List<string>();

                Console.WriteLine("\n=== Lista general ===");
                for (int i = 0; i < cantidadPersonas; i++)
                {
                    Console.WriteLine($"{nombres[i]} - {edades[i]} años");

                    if (edades[i] >= 18)
                        mayores.Add($"{nombres[i]} - {edades[i]} años");
                    else
                        menores.Add($"{nombres[i]} - {edades[i]} años");
                }

                // Mostrar listados solo si tienen datos
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

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
