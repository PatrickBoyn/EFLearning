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
            modelBuilder.Entity<Machine>(entity => 
            {
                entity.Property(e => e.MachineId).HasColumnName("MachineId");

                entity.Property(e => e.GeneralRole)
                      .IsRequired()
                      .HasMaxLength(25)
                      .IsUnicode(false);

                entity.Property(e => e.InstalledRoles)
                      .IsRequired()
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineTypeID");

                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(25)
                      .IsUnicode(false);

                entity.Property(e => e.OperatingSysId).HasColumnName("OperatingSysID");

                entity.HasOne(d => d.MachineType)
                      .WithMany(p => p.Machine)
                      .HasForeignKey(d => d.MachineId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_MachineType");
            });
        }
    }
}