namespace Videoclub.Modelos
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int CantidadDisponible { get; set; }

        // TODO: agregar relación con Alquiler cuando se implemente el punto 3
    }
}
