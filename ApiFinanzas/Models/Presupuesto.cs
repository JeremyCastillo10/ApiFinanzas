using System.ComponentModel.DataAnnotations;

namespace ApiFinanzas.Models
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public virtual Usuario Usuario { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public decimal MontoPlaneado { get; set; }
        public decimal MontoGastado { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
