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
			string estado = Disponible ? "Disponible" : "Ocupado";
			return $"Título: {Titulo}, Autor: {Autor}, Género: {Genero}, Año: {Anio}, Estado: {estado}";
		}
	}
}