using Shared.DTOs.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Transaccion
{
    public class Transaccion_DTO
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;

        public decimal? Monto { get; set; } = 0;
        public DateTime Fecha { get; set; }
        public string ?Tipo { get; set; } = string.Empty;

        public int CategoriaId { get; set; }
        public Categoria_DTO ?Categoria { get; set; }
        public string? Descripcion { get; set; } = string.Empty;
        public bool Eliminado = false;
        
        public DateTime FechaCreacion { get; set; }= DateTime.Now;
        public DateTime FechaActualizacion { get; set; } 

    }
}
