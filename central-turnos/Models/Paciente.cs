using central_turnos.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace central_turnos.Models;

[Table("Paciente")]
public class Paciente
{
    [Key]
    public int Id { get; set; }
    [Column(TypeName = "varchar(50)")]
    [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
    [Required(ErrorMessage =  "El apellido no puede ser nulo")]
    [PrimeraLetraMayuscula]
    public string? Apellido { get; set; }
    [Column(TypeName = "varchar(50)")]
    [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
    [Required(ErrorMessage = "El nombre no puede ser nulo")]
    [PrimeraLetraMayuscula]
    public string? Nombre { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    [Column(TypeName = "char(8)")]
    [StringLength(8, ErrorMessage = "Only 8 character are allowed")]
    public string? DNI { get; set; }
    [MayorCeroAtributte]
    public int NroMatricula { get; set; }
}
