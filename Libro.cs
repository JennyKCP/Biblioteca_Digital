namespace BibliotecaDigital
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }
        public bool Ocupado { get; set; }
        public bool Prestado { get; set; }

        public Libro(string titulo, string autor, string genero, int anio)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            Anio = anio;
            Disponible = true;
            Ocupado = false;
            Prestado = false;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({Anio}) | Género: {Genero} | " +
                   $"Disponible: {Disponible} | Ocupado: {Ocupado} | Prestado: {Prestado}";
        }
    }
}