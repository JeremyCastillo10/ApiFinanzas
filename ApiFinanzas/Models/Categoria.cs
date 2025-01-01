namespace ApiFinanzas.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nombre { get; set; } = string.Empty; // Ejemplo: Alimentación, Transporte
        public string? Tipo { get; set; }
        public string? Color { get; set; }
    }
}
