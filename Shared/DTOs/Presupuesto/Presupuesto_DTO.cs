using Shared.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Presupuesto
{
    public class Presupuesto_DTO
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;

        public int CategoriaId { get; set; }
        public Categoria_DTO Categoria { get; set; } = null!;

        public decimal MontoPlaneado { get; set; } 
        public decimal MontoGastado { get; set; } = 0; 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public bool Eliminado = false;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }
    }
}
