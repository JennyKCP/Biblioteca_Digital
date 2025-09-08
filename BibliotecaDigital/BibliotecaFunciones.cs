using System;

namespace BibliotecaDigital
{
    public class BibliotecaFunciones
    {
        public ListaDobleLibros listaLibros;
        public BSTLibros bstLibros;

        public BibliotecaFunciones()
        {
            listaLibros = new ListaDobleLibros();
            bstLibros = new BSTLibros();
        }

        public void AgregarLibro(Libro libro)
        {
            listaLibros.AgregarLibro(libro);
            bstLibros.InsertarLibroBST(libro);
        }

        public void MostrarLibrosPorGenero(string genero)
        {
            NodoLista? actual = listaLibros.Primero;
            while (actual != null)
            {
                if (actual.Libro.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine(actual.Libro);
                actual = actual.Siguiente;
            }
        }

        public void PrestarLibro(string titulo)
        {
            Libro? libro = bstLibros.BuscarLibroBST(titulo);
            if (libro != null && libro.Disponible)
            {
                libro.Disponible = false;
                libro.Ocupado = true;
                libro.Prestado = true;
                Console.WriteLine($"Libro '{titulo}' prestado con éxito.");
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no está disponible.");
            }
        }

        public void DevolverLibro(string titulo)
        {
            Libro? libro = bstLibros.BuscarLibroBST(titulo);
            if (libro != null && libro.Prestado)
            {
                libro.Disponible = true;
                libro.Ocupado = false;
                libro.Prestado = false;
                Console.WriteLine($"Libro '{titulo}' devuelto con éxito.");
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no estaba prestado.");
            }
        }
		
		public void EliminarLibro(string titulo)
		{
			bstLibros.EliminarLibro(titulo);
			listaLibros.EliminarLibro(titulo);
		}

        public void ReporteLibros()
        {
            Console.WriteLine("=== Libros Disponibles ===");
            NodoLista? actual = listaLibros.Primero;
            while (actual != null)
            {
                if (actual.Libro.Disponible)
                    Console.WriteLine(actual.Libro);
                actual = actual.Siguiente;
            }

            Console.WriteLine("=== Libros Prestados ===");
            actual = listaLibros.Primero;
            while (actual != null)
            {
                if (actual.Libro.Prestado)
                    Console.WriteLine(actual.Libro);
                actual = actual.Siguiente;
            }
        }
    }
}