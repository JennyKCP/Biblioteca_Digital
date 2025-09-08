using System;

namespace BibliotecaDigital
{
    class Biblioteca_Digital
    {
        static void Main(string[] args)
        {
            BibliotecaFunciones biblioteca = new BibliotecaFunciones();

            biblioteca.AgregarLibro(new Libro("Cien Años de Soledad", "Gabriel Garcia Marquez", "Novela", 1967));
            biblioteca.AgregarLibro(new Libro("Don Quijote", "Miguel de Cervantes", "Novela", 1605));
            biblioteca.AgregarLibro(new Libro("1984", "George Orwell", "Distopía", 1949));
            biblioteca.AgregarLibro(new Libro("Fundación", "Isaac Asimov", "Ciencia Ficción", 1951));
			biblioteca.AgregarLibro(new Libro("Orgullo y Prejuicio", "Jane Austen", "Romántico", 1813));
			biblioteca.AgregarLibro(new Libro("Bajo la misma estrella", "John Green", "Romántico", 2012));
			biblioteca.AgregarLibro(new Libro("El amor en los tiempos del cólera", "Gabriel García Márquez", "Romántico", 1985));
			biblioteca.AgregarLibro(new Libro("El Principito", "Antoine de Saint-Exupéry", "Infantil", 1943));
			biblioteca.AgregarLibro(new Libro("Alicia en el País de las Maravillas", "Lewis Carroll", "Infantil", 1865));
			biblioteca.AgregarLibro(new Libro("Charlie y la fábrica de chocolate", "Roald Dahl", "Infantil", 1964));
			biblioteca.AgregarLibro(new Libro("It", "Stephen King", "Terror", 1986));
			biblioteca.AgregarLibro(new Libro("Drácula", "Bram Stoker", "Terror", 1897));
			biblioteca.AgregarLibro(new Libro("El resplandor", "Stephen King", "Terror", 1977));
			biblioteca.AgregarLibro(new Libro("Hamlet", "William Shakespeare", "Dramático", 1603));
			biblioteca.AgregarLibro(new Libro("Los miserables", "Victor Hugo", "Dramático", 1862));
			biblioteca.AgregarLibro(new Libro("La casa de los espíritus", "Isabel Allende", "Dramático", 1982));
			biblioteca.AgregarLibro(new Libro("Fundación", "Isaac Asimov", "Ciencia Ficción", 1951));
			biblioteca.AgregarLibro(new Libro("1984", "George Orwell", "Ciencia Ficción", 1949));
			biblioteca.AgregarLibro(new Libro("Dune", "Frank Herbert", "Ciencia Ficción", 1965));
			biblioteca.AgregarLibro(new Libro("Steve Jobs", "Walter Isaacson", "Biográfico", 2011));
			biblioteca.AgregarLibro(new Libro("El diario de Ana Frank", "Ana Frank", "Biográfico", 1947));
			biblioteca.AgregarLibro(new Libro("Long Walk to Freedom", "Nelson Mandela", "Biográfico", 1994));
			biblioteca.AgregarLibro(new Libro("Los 7 hábitos de la gente altamente efectiva", "Stephen R. Covey", "Autoayuda", 1989));
			biblioteca.AgregarLibro(new Libro("Poder del ahora", "Eckhart Tolle", "Autoayuda", 1997));
			biblioteca.AgregarLibro(new Libro("Cómo ganar amigos e influir sobre las personas", "Dale Carnegie", "Autoayuda", 1936));

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== Menú Biblioteca Digital ===");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Buscar libro por título");
                Console.WriteLine("3. Mostrar todos los libros en orden alfabético");
                Console.WriteLine("4. Mostrar libros por género");
                Console.WriteLine("5. Prestar libro");
                Console.WriteLine("6. Devolver libro");
                Console.WriteLine("7. Eliminar libro");
                Console.WriteLine("8. Reporte de libros");
                Console.WriteLine("9. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Console.Write("Título: ");
                        string titulo = Console.ReadLine() ?? "";
                        Console.Write("Autor: ");
                        string autor = Console.ReadLine() ?? "";
                        Console.Write("Género: ");
                        string genero = Console.ReadLine() ?? "";
                        Console.Write("Año: ");
                        int anio = int.TryParse(Console.ReadLine(), out int year) ? year : 0;

                        Libro nuevoLibro = new Libro(titulo, autor, genero, anio);
                        biblioteca.AgregarLibro(nuevoLibro);
                        Console.WriteLine("Libro agregado correctamente.");

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "2":
                        Console.Write("Título a buscar: ");
                        string buscar = Console.ReadLine() ?? "";
                        Libro? encontrado = biblioteca.bstLibros.BuscarLibroBST(buscar);
                        if (encontrado != null)
                            Console.WriteLine(encontrado);
                        else
                            Console.WriteLine("Libro no encontrado.");

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "3":
                        Console.WriteLine("=== Libros en Orden Alfabetico ===");
                        biblioteca.bstLibros.RecorrerEnOrden(biblioteca.bstLibros.Raiz);

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "4":
                        Console.Write("Ingrese el género: ");
                        string buscarGenero = Console.ReadLine() ?? "";
                        biblioteca.MostrarLibrosPorGenero(buscarGenero);

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "5":
                        Console.Write("Título a prestar: ");
                        string prestar = Console.ReadLine() ?? "";
                        biblioteca.PrestarLibro(prestar);

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "6":
                        Console.Write("Título a devolver: ");
                        string devolver = Console.ReadLine() ?? "";
                        biblioteca.DevolverLibro(devolver);

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "7":
                        Console.Write("Título a eliminar: ");
                        string eliminar = Console.ReadLine() ?? "";
                        biblioteca.EliminarLibro(eliminar); 
                        Console.WriteLine("Operación de eliminación realizada.");

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "8":
                        biblioteca.ReporteLibros();

						Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
    					Console.ReadKey();
    					Console.Clear();
                        break;

                    case "9":
                        salir = true;
                        Console.WriteLine("¡Gracias por usar la Biblioteca Digital!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}