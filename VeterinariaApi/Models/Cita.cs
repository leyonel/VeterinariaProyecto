using System;
using VeterinariaAPI.Models;

namespace VeterinariaAPI.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime FechaCita { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int DoctorId { get; set; }
        public Usuario Doctor { get; set; }
        public string Estado { get; set; } // "Pendiente, Cancelada, Realizada"
    }
}
