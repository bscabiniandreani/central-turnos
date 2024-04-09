using central_turnos.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DBTurnosContext : DbContext
    {
        public DBTurnosContext(DbContextOptions<DBTurnosContext> options) : base(options)
        { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

    }
}
