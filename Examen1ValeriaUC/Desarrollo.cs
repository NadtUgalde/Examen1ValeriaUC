using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static Examen1ValeriaUC.Desarrollo;

namespace Examen1ValeriaUC
{
    internal class Desarrollo
    {

        interface ILibro
        {
            void Prestar();
            void Devolver();
            void MostrarInformacion();
        }

        public class Libro : ILibro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Apublicacion { get; set; }
            public float Precio { get; set; }
            public bool Disponible { get; set; }

            public void Prestar()
            {
                if (Disponible)
                {
                    Disponible = false;
                    Console.WriteLine("El libro esta disponible.");
                }
                else
                {
                    Console.WriteLine("El libro no está disponible.");
                }
            }
            public void Devolver()
            {
                if (!Disponible)
                {
                    Disponible = true;
                    Console.WriteLine("El libro se devolvio.");
                }
                else
                {
                    Console.WriteLine("El libro esta disponible.");
                }
            }
            public void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}");
                Console.WriteLine($"Autor: {Autor}");
                Console.WriteLine($"Año de publicación: {Apublicacion}");
                Console.WriteLine($"Precio: {Precio}");
                Console.WriteLine($"Disponible: {(Disponible ? "Sí" : "No")}");

            }

        }

        public class Biblioteca : Libro
        {
            List<Libro> books = new List<Libro>();

            Libro libro = new Libro
            {
                Titulo = "De ninguna parte",
                Autor = "Julia Navarro",
                Apublicacion = "2015",
                Precio = 5000,
                Disponible = true,
            };


            public void agregarlibro()
            {
                Console.Clear();
                string op = "S";
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("** Agregar Libro **");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Titulo: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Año de publicación: ");
                    string apublicacion = Console.ReadLine();
                    Console.Write("Precio: ");
                    float precio = float.Parse(Console.ReadLine());

                    Libro book = new Libro
                    {
                        Titulo = titulo,
                        Autor = autor,
                        Apublicacion = apublicacion,
                        Precio = precio,
                        Disponible = true,
                    };

                    books.Add(book);

                    Console.Write("¿Deseas agregar otro libro? (S/N): ");
                    op = Console.ReadLine().ToUpper();

                } while (op == "S");
            }

            public void consultarlibro()
            {


                foreach (var book in books)
                {
                    Console.WriteLine(" ═══════════════════════════════");
                    Console.WriteLine("Título: " + book.Titulo);
                    Console.WriteLine(" ═══════════════════════════════");
                }


            }


            public void eliminarLibro()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("** Eliminar Libro **");
                Console.ForegroundColor = ConsoleColor.White;


                bool seguir = true;

                do
                {
                    consultarlibro();
                    Console.Write("Digite el título del libro que desea eliminar: ");
                    string titulo = Console.ReadLine();
                    Libro buscarlibro = books.Find(book => book.Titulo.Equals(titulo));

                    if (buscarlibro != null)
                    {
                        books.Remove(buscarlibro);
                        Console.WriteLine("El libro ha sido eliminado correctamente.");
                        seguir = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No se encontró ningún libro con el título especificado. Intente de nuevo");
                        Console.ReadLine();
                        break;

                    }



                } while (seguir == false);
                Console.WriteLine();
            }

            public void mostrarlibro()
            {
                foreach (var book in books)
                {
                    Console.WriteLine(" ═══════════════════════════════");
                    Console.WriteLine("Título: " + book.Titulo);
                    Console.WriteLine("Autor: " + book.Autor);
                    Console.WriteLine("Año de publicación: " + book.Apublicacion);
                    Console.WriteLine("Precio: " + book.Precio);
                    Console.WriteLine("Disponible: " + book.Disponible);
                    Console.WriteLine(" ═══════════════════════════════");
                }
                Console.WriteLine();
            }

            public void buscarlibro()
            {
                bool seguir = false;
                do
                {

                    Console.Write("Digite el título del libro que desea buscar: ");
                    string titulo = Console.ReadLine();
                    Libro buscarlibro = books.Find(book => book.Titulo.Equals(titulo));

                    if (buscarlibro != null)
                    {
                        Console.WriteLine(" ═══════════════════════════════");
                        Console.WriteLine("Título: " + Titulo);
                        Console.WriteLine("Autor: " + Autor);
                        Console.WriteLine("Año de publicación: " + Apublicacion);
                        Console.WriteLine("Precio: " + Precio);
                        Console.WriteLine("Disponible: " + Disponible);
                        Console.WriteLine(" ═══════════════════════════════");
                        seguir = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No se encontró ningún libro con el título especificado. Intente de nuevo");
                        Console.ReadLine();
                        break;

                    }



                } while (seguir == false);
            }

        }


    }
}

    
    

