using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        
        public DbSet<Ongs> Ongs { get; set; }
        public DbSet<Incident> Incidents { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>()
                .HasOne(b => b.Ongs).WithMany(x => x.Incidents).HasForeignKey(p => p.OngsId);
        }

    }
}