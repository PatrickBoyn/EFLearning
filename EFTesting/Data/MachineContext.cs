using EFTesting.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTesting.Data
{
    class MachineContext : DbContext
    {
        public DbSet<Machine> Machine { get; set; }
        public DbSet<MachineType> MachineType { get; set; }
        public DbSet<MachineWarranty> MachineWarranty { get; set; }
        public DbSet<OperatingSys> OperatingSys { get; set; }
        public DbSet<SupportLog> SupportLog { get; set; }
        public DbSet<SupportTicket> SupportTicket { get; set; }
        public DbSet<WarrantyProvider> WarrantyProvider { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=ServerName;Database=BegEFCore2;Trusted_Connection=false;User Id=sa;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>(entity => {
                entity.Property(e => e.MachineId).HasColumnName("MachineId");

                
            });
        }
    }
}