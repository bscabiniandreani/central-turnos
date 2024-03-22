}namespace central_turnos.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int PacienteId { get; set; }
        public int MedicoId { get; set; }
    }
}
