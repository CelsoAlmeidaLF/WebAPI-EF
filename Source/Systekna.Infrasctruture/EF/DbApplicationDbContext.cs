using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Systekna.Core;

namespace Systekna.Infrasctruture
{
    public class DbApplicationDbContext : DbContext
    {
        public DbApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(SqlConnection.connectionString);
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<EntityDespesa> TB_DESPESA { get; set; }
    }
}