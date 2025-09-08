namespace BibliotecaDigital
{
    public class NodoLista
    {
        public Libro Libro { get; set; }
        public NodoLista? Anterior { get; set; }
        public NodoLista? Siguiente { get; set; }

        public NodoLista(Libro libro)
        {
            Libro = libro;
            Anterior = null;
            Siguiente = null;
        }
    }
}