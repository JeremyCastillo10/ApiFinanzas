using Shared.DTOs.Categoria;
using Shared.DTOs.Usuarios;
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
        public int UsuarioId { get; set; }
        public Usuario_DTO Usuario { get; set; } = null!;

        public int CategoriaId { get; set; }
        public Categoria_DTO Categoria { get; set; } = null!;

        public decimal MontoPlaneado { get; set; } 
        public decimal MontoGastado { get; set; } = 0; 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } 
    }
}
