using DeusVivo.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace DeusVivo.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cargo> Cargos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CriacaoDataHora").CurrentValue = DateTime.Now;
                    //entry.Property("CriacaoId").CurrentValue = 1;
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
