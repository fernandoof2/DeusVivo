using DeusVivo.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeusVivo.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<CargoEO> Cargos { get; set; }
        public DbSet<CompanhiaEO> Companhias { get; set; }
        public DbSet<UsuarioEO> Usuarios { get; set; }
        public DbSet<UsuarioPerfilEO> UsuariosPerfis { get; set; }
        public DbSet<PerfilEO> Perfis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioPerfilEO>()
                .HasKey(c => new { c.UsuarioId, c.PerfilId });
        }

        public override int SaveChanges()
        {            
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.OriginalValues.Properties.Where(x => x.Name == "CriacaoId").ToList().Count == 0)
                    continue;

                if (entry.State == EntityState.Added)
                {
                    entry.Property("CriacaoDataHora").CurrentValue = DateTime.Now;
                    entry.Property("AlteracaoDataHora").CurrentValue = DateTime.Now;
                    //entry.Property("CriacaoId").CurrentValue = User.Identity.Name;
                }
                else if(entry.State == EntityState.Modified)
                {
                    entry.Property("AlteracaoDataHora").CurrentValue = DateTime.Now;
                    //entry.Property("AlteracaoId").CurrentValue = 1;
                }
            }

            return base.SaveChanges();
        }
    }
}
