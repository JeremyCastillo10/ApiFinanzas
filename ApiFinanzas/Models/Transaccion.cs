using System.ComponentModel.DataAnnotations;

namespace ApiFinanzas.Models
{
    public class Transaccion
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public virtual Usuario Usuario { get; set; }

        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; } = null!;

        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
