namespace BibliotecaDigital
{
    public class NodoArbol
    {
        public Libro Libro { get; set; }
        public NodoArbol? Izquierdo { get; set; }
        public NodoArbol? Derecho { get; set; }

        public NodoArbol(Libro libro)
        {
            Libro = libro;
            Izquierdo = null;
            Derecho = null;
        }
    }
}