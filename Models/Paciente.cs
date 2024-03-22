namespace central_turnos.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public int NroMatricula { get; set; }
    }
}
