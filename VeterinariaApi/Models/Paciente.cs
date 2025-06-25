using System;
using VeterinariaAPI.Models;
using System.ComponentModel.DataAnnotations;
namespace VeterinariaAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float Peso { get; set; }

        [Required]
        public int PropietarioId { get; set; }

        public Usuario? Propietario { get; set; }
    }
}