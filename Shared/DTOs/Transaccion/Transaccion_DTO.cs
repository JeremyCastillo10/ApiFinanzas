using Shared.DTOs.Categoria;
using Shared.DTOs.Usuarios;
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
        public int UsuarioId { get; set; }
        public Usuario_DTO Usuario { get; set; } = null!;

        public decimal ?Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string ?Tipo { get; set; } 

        public int CategoriaId { get; set; }
        public Categoria_DTO Categoria { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}
