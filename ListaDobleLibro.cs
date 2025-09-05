using System;

namespace BibliotecaDigital
{
	public class ListaDobleLibros
	{
		public NodoLista? Primero { get; private set; }
		public NodoLista? Ultimo { get; private set; }

		public ListaDobleLibros()
		{
			Primero = null;
			Ultimo = null;
		}

		public bool EstaVacia()
		{
			return Primero == null;
		}

		public void AgregarLibro(Libro libro)
		{
			NodoLista nuevo = new NodoLista(libro);
			if (EstaVacia())
			{
				Primero = nuevo;
				Ultimo = nuevo;
			}
			else
			{
				Ultimo!.Siguiente = nuevo;
				nuevo.Anterior = Ultimo;
				Ultimo = nuevo;
			}
		}

		public void EliminarLibro(string titulo)
		{
			NodoLista? actual = Primero;

			while (actual != null)
			{
				if (actual.Libro.Titulo == titulo)
				{
					if (actual.Anterior != null)
						actual.Anterior.Siguiente = actual.Siguiente;
					else
						Primero = actual.Siguiente;

					if (actual.Siguiente != null)
						actual.Siguiente.Anterior = actual.Anterior;
					else
						Ultimo = actual.Anterior;

					Console.WriteLine($"Libro '{titulo}' eliminado de la lista.");
					return;
				}
				actual = actual.Siguiente;
			}

			Console.WriteLine($"Libro '{titulo}' no encontrado.");
		}

		public void RecorrerAdelante()
		{
			NodoLista? actual = Primero;
			while (actual != null)
			{
				Console.WriteLine(actual.Libro);
				actual = actual.Siguiente;
			}
		}

		public void RecorrerAtras()
		{
			NodoLista? actual = Ultimo;
			while (actual != null)
			{
				Console.WriteLine(actual.Libro);
				actual = actual.Anterior;
			}
		}

		public Libro? BuscarLibro(string titulo)
		{
			NodoLista? actual = Primero;
			while (actual != null)
			{
				if (actual.Libro.Titulo == titulo)
					return actual.Libro;

				actual = actual.Siguiente;
			}
			return null;
		}
	}
}
