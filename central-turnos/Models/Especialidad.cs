using central_turnos.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace central_turnos.Models
{
    [Table("Especialidad")]
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
        [PrimeraLetraMayuscula]
        public string? Nombre { get; set; }
    }
}
