using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1ValeriaUC
{
    internal class Menu
    {
        public static void menu()
        {
            Desarrollo desarrollo = new Desarrollo();
            Desarrollo.Biblioteca biblioteca = new Desarrollo.Biblioteca();

            string opcion;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\t\tMenu de Biblioteca");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" ╔═══════════════════════════════════════════════════╗");
                Console.WriteLine(" ║        SELECCIONE UNA OPCIÓN DEL MENÚ             ║");
                Console.WriteLine(" ╚═══════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t 1-Agregar un libro a la biblioteca");
                Console.WriteLine("\t 2-Eliminar un libro de la biblioteca");
                Console.WriteLine("\t 3-Mostrar todos los libros de la biblioteca");
                Console.WriteLine("\t 4-Buscar libros");
                Console.WriteLine("\t 5-Mostrar libro de mayor precio");
                Console.WriteLine("\t 6-Mostrar los tres libros más baratos");
                Console.WriteLine("\t 7-Buscar libros por inicio del nombre del autor");
                Console.WriteLine("\t 8-Salir del programa");
                Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write(" → "); Console.ForegroundColor = ConsoleColor.White; opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": biblioteca.agregarlibro(); ; break;
                    case "2": biblioteca.eliminarLibro(); break;
                    case "3": biblioteca.mostrarlibro(); break;
                    case "4": biblioteca.buscarlibro(); break;
                    case "5": biblioteca.mostrarlibro(); break;
                    case "6": biblioteca.mostrarlibro(); break;
                    case "7": biblioteca.buscarlibro(); break;
                    case "8": Console.WriteLine( "Hasta luego"); break;
                    default: break;

                }
                Console.ReadLine();
            } while (!opcion.Equals("8"));


        }
    }
}
