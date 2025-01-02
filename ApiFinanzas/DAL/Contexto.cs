using ApiFinanzas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiFinanzas.DAL
{
    public class Contexto : IdentityDbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<MetaFinanciera> MetaFinancieras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


    }
}
