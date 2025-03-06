using System;
using VeterinariaAPI.Models;

namespace VeterinariaAPI.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaLote { get; set; }
        public string Tipo { get; set; } // "Medicamento, alimento, accesorio"
        public string Descripcion { get; set; }
        public float Precio { get; set; }
    }
}
