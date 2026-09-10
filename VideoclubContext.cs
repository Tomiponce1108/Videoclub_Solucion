using Microsoft.EntityFrameworkCore;
using Videoclub.Modelos;

namespace Videoclub.Datos
{
    public class VideoclubContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Usamos SQLite porque es simple de correr sin instalar un servidor de base de datos.
            // El archivo videoclub.db se crea solo en la carpeta del proyecto.
            options.UseSqlite("Data Source=videoclub.db");
        }
    }
}
