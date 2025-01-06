using System.ComponentModel.DataAnnotations;

namespace ApiFinanzas.Models
{
    public class MetaFinanciera
    {
        [Key]
        public int MetaId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string Nombre { get; set; } 
        public decimal MontoMeta { get; set; }
        public decimal MontoAhorrado { get; set; } 
        public DateTime FechaMeta { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
