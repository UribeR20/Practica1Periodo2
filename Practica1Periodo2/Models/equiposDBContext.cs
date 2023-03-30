using Microsoft.EntityFrameworkCore;
using Practica1Periodo2.Models;
namespace Practica1Periodo2.Models
{
    public class equiposDBContext : DbContext
    {

        public equiposDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<estados_equipo> estados_equipo { get; set; }
        public DbSet<estados_reserva> estados_reserva { get; set; }
        public DbSet<carreras> carreras { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<facultades> facultades { get; set; }

        public DbSet<tipo_equipo> tipo_equipo { get; set; }



    }
}
