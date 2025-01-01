namespace ApiFinanzas.Models
{
    public class MetaFinanciera
    {
        public int MetaId { get; set; }
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public string? Nombre { get; set; } = string.Empty;
        public decimal? MontoMeta { get; set; }
        public decimal? MontoAhorrado { get; set; } = 0;
        public DateTime FechaMeta { get; set; }
        public string? Estado { get; set; } = "En Progreso";
    }
}
