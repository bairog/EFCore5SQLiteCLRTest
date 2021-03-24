using DomainObjects;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class PlanesDbContext : DbContext
    {
        public PlanesDbContext()
        { }

        public PlanesDbContext(DbContextOptions<PlanesDbContext> options)
            : base(options)
        { }


        public DbSet<PlaneBoard> PlaneBoards { get; set; }
        public DbSet<PlaneFlight> PlaneFlights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite((new SqliteConnectionStringBuilder() { DataSource = @"d:\test.db" }).ToString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaneBoard>().HasIndex(ur => new { ur.PlaneType, ur.PlaneBoardNo }).IsUnique();
        }
    }
}
