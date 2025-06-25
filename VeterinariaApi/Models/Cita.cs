using System;
using System.ComponentModel.DataAnnotations;
using VeterinariaAPI.Models;

namespace VeterinariaAPI.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required]
        public DateTime FechaCita { get; set; }

        public string Motivo { get; set; }

        [Required]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public Usuario Doctor { get; set; }
        public string Estado { get; set; } // "Pendiente, Cancelada, Realizada"
    }
}
