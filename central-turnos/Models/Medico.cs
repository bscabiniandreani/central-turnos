using central_turnos.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace central_turnos.Models;

[Table("Medico")]
public class Medico
{
    [Key]
    public int idMedico { get; set; }
    [Column(TypeName = "varchar(50)")]
    [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
    [PrimeraLetraMayuscula]
    public string? Apellido { get; set; }
    [Column(TypeName = "varchar(50)")]
    [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
    [PrimeraLetraMayuscula]
    public string? Nombre { get; set; }
    [Column(TypeName = "char(6)")]
    [StringLength(6, ErrorMessage = "Only 6 character are allowed")]
    public string? Matricula { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    [MayorCeroAtributte]
    public int EspecialidadId { get; set; }
}
