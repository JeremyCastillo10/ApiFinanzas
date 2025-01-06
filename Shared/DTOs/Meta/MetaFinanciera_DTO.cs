using Shared.DTOs.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Meta
{
    public class MetaFinanciera_DTO
    {
        public int MetaId { get; set; }
        public string UserId { get; set; } = string.Empty;

        public string ?Nombre { get; set; } = string.Empty; 
        public decimal ?MontoMeta { get; set; } 
        public decimal ?MontoAhorrado { get; set; } = 0; 
        public DateTime FechaMeta { get; set; }
        public string ?Estado { get; set; } = "En Progreso";
        public bool Eliminado = false;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaActualizacion { get; set; }
    }
}

