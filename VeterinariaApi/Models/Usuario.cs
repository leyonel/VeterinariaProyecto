using System;
using VeterinariaAPI.Models;

namespace VeterinariaAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }
        public string TipoUsuario { get; set; } // "Cliente, Doctor o Adminsitrador"
    }
}

