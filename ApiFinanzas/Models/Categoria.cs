using System.ComponentModel.DataAnnotations;

namespace ApiFinanzas.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; } 
        public string Tipo { get; set; }
        public string Color { get; set; }
    }
}
