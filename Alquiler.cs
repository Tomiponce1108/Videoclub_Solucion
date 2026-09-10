using System;

namespace Videoclub.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }

        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }

        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }

        public decimal Monto { get; set; }

        // TODO: calcular Monto según cantidad de días y el recargo del 10% por día
        // si FechaDevolucionReal > FechaDevolucionPrevista
    }
}
