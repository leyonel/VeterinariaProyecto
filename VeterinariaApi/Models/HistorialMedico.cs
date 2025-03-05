using System;
using VeterinariaAPI.Models;

namespace VeterinariaAPI.Models
{
    public class HistorialMedico
    {
        public int Id { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public DateTime FechaConsulta { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}