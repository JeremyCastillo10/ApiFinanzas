using System.ComponentModel.DataAnnotations;

namespace ApiFinanzas.Models
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public decimal MontoPlaneado { get; set; }
        public decimal MontoGastado { get; set; } 
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
