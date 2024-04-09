using central_turnos.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace central_turnos.Models
{
    [Table("Turno")]
    public class Turno
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan Hora { get; set; }
        [MayorCeroAtributte]
        public int PacienteId { get; set; }
        [MayorCeroAtributte]
        public int MedicoId { get; set; }
    }
}
