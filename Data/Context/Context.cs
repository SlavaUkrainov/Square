using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class Context : DbContext
    {
        // ReSharper disable once UnusedMember.Global
        public DbSet<Square> Squares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=postgres;Port=5432;Username=postgres;Password=postgres;Database=postgres;";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}