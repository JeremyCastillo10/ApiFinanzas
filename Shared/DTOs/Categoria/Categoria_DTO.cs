using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Categoria
{
    public class Categoria_DTO
    {
        public int CategoriaId { get; set; }
        public string ?Nombre { get; set; } = string.Empty; // Ejemplo: Alimentación, Transporte
        public string ?Tipo { get; set; } 
        public string ?Color { get; set; }
    }
}
