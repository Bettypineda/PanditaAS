namespace paginapandita.Models
{
    public class MangaViewModel
    {
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string PortadaUrl { get; set; }
        public List<Personaje> Personajes { get; set; }
    }

    public class Personaje
    {
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Poder { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
    }
}