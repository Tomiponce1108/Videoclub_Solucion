using System;
using Videoclub.Datos;
using Videoclub.Modelos;

namespace Videoclub
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new VideoclubContext())
            {
                // Crea la base de datos si no existe todavía
                contexto.Database.EnsureCreated();

                bool salir = false;
                while (!salir)
                {
                    Console.WriteLine("\n===== MENU VIDEOCLUB =====");
                    Console.WriteLine("1. Registrar pelicula");
                    Console.WriteLine("2. Registrar socio");
                    Console.WriteLine("3. Registrar alquiler");
                    Console.WriteLine("4. Reporte de alquiler por socio");
                    Console.WriteLine("5. Reporte de socios con demora");
                    Console.WriteLine("6. Reporte de peliculas mas alquiladas");
                    Console.WriteLine("7. Reporte del socio que mas alquilo");
                    Console.WriteLine("0. Salir");
                    Console.Write("Elegi una opcion: ");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            RegistrarPelicula(contexto);
                            break;
                        case "2":
                            RegistrarSocio(contexto);
                            break;
                        case "3":
                            // TODO: pedir socio y pelicula(s), calcular monto y dias
                            Console.WriteLine("Funcionalidad en desarrollo.");
                            break;
                        case "4":
                            // TODO: recorrer alquileres sin FechaDevolucionReal, agrupados por socio
                            Console.WriteLine("Funcionalidad en desarrollo.");
                            break;
                        case "5":
                            // TODO: filtrar alquileres donde FechaDevolucionReal > FechaDevolucionPrevista
                            Console.WriteLine("Funcionalidad en desarrollo.");
                            break;
                        case "6":
                            // TODO: agrupar alquileres por Pelicula y contar, ordenar descendente
                            Console.WriteLine("Funcionalidad en desarrollo.");
                            break;
                        case "7":
                            // TODO: agrupar alquileres por Socio y contar, tomar el maximo
                            Console.WriteLine("Funcionalidad en desarrollo.");
                            break;
                        case "0":
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
            }
        }

        static void RegistrarPelicula(VideoclubContext contexto)
        {
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Console.Write("Cantidad disponible: ");
            int cantidad = int.Parse(Console.ReadLine());

            var pelicula = new Pelicula
            {
                Titulo = titulo,
                Autor = autor,
                CantidadDisponible = cantidad
            };

            contexto.Peliculas.Add(pelicula);
            contexto.SaveChanges();

            Console.WriteLine("Pelicula registrada correctamente.");
        }

        static void RegistrarSocio(VideoclubContext contexto)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("DNI: ");
            string dni = Console.ReadLine();

            Console.Write("Telefono: ");
            string telefono = Console.ReadLine();

            var socio = new Socio
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Telefono = telefono
            };

            contexto.Socios.Add(socio);
            contexto.SaveChanges();

            Console.WriteLine("Socio registrado correctamente.");
        }
    }
}
