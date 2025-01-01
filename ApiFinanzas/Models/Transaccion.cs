﻿namespace ApiFinanzas.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        public decimal? Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string? Tipo { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}