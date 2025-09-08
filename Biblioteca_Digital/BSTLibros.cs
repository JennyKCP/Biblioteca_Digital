using System;

namespace BibliotecaDigital
{
	public class BSTLibros
	{
		public NodoArbol? Raiz { get; private set; }

		public BSTLibros()
		{
			Raiz = null;
		}

		public void InsertarLibroBST(Libro libro)
		{
			Raiz = InsertarRecursivo(Raiz, libro);
		}

		public NodoArbol InsertarRecursivo(NodoArbol? nodo, Libro libro)
		{
			if (nodo == null)
				return new NodoArbol(libro);

			int comparacionTitulo = string.Compare(libro.Titulo, nodo.Libro.Titulo, StringComparison.OrdinalIgnoreCase);

			if (comparacionTitulo < 0)
				nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, libro);
			else if (comparacionTitulo > 0)
				nodo.Derecho = InsertarRecursivo(nodo.Derecho, libro);
			else
			{
				int comparacionGenero = string.Compare(libro.Genero, nodo.Libro.Genero, StringComparison.OrdinalIgnoreCase);
				if (comparacionGenero < 0)
					nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, libro);
				else
					nodo.Derecho = InsertarRecursivo(nodo.Derecho, libro);
			}

			return nodo;
		}

		public Libro? BuscarLibroBST(string titulo)
		{
			NodoArbol? actual = Raiz;
			while (actual != null)
			{
				int comparacion = string.Compare(titulo, actual.Libro.Titulo, StringComparison.OrdinalIgnoreCase);
				if (comparacion == 0)
					return actual.Libro;
				else if (comparacion < 0)
					actual = actual.Izquierdo;
				else
					actual = actual.Derecho;
			}
			return null;
		}

		public void RecorrerEnOrden(NodoArbol? nodo)
		{
			if (nodo != null)
			{
				RecorrerEnOrden(nodo.Izquierdo);
				Console.WriteLine(nodo.Libro);
				RecorrerEnOrden(nodo.Derecho);
			}
		}

		public void RecorrerPreOrden(NodoArbol? nodo)
		{
			if (nodo != null)
			{
				Console.WriteLine(nodo.Libro);
				RecorrerPreOrden(nodo.Izquierdo);
				RecorrerPreOrden(nodo.Derecho);
			}
		}

		public void RecorrerPostOrden(NodoArbol? nodo)
		{
			if (nodo != null)
			{
				RecorrerPostOrden(nodo.Izquierdo);
				RecorrerPostOrden(nodo.Derecho);
				Console.WriteLine(nodo.Libro);
			}
		}
		public void EliminarLibro(string titulo)
		{
  			Raiz = EliminarLibroBST(Raiz, titulo);
		}

		public NodoArbol? EliminarLibroBST(NodoArbol? nodo, string titulo)
		{
			if (nodo == null) return null;

			int comparacion = string.Compare(titulo, nodo.Libro.Titulo, StringComparison.OrdinalIgnoreCase);

			if (comparacion < 0)
				nodo.Izquierdo = EliminarLibroBST(nodo.Izquierdo, titulo);
			else if (comparacion > 0)
				nodo.Derecho = EliminarLibroBST(nodo.Derecho, titulo);
			else
			{
				if (nodo.Izquierdo == null && nodo.Derecho == null)
					return null;

				if (nodo.Izquierdo == null) return nodo.Derecho;
				if (nodo.Derecho == null) return nodo.Izquierdo;

				NodoArbol sucesor = EncontrarMinimo(nodo.Derecho);
				nodo.Libro = sucesor.Libro;
				nodo.Derecho = EliminarLibroBST(nodo.Derecho, sucesor.Libro.Titulo);
			}

			return nodo;
		}

		public NodoArbol EncontrarMinimo(NodoArbol nodo)
		{
			while (nodo.Izquierdo != null)
				nodo = nodo.Izquierdo;
			return nodo;
		}
	}
}
