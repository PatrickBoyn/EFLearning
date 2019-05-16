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
            //Properties and relationships for the Machine class.
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

            modelBuilder.Entity<MachineType>(entity => {
                entity.Property(e => e.MachineTypeId).HasColumnName("MachineTypeID");

                entity.Property(e => e.Description)
                      .HasMaxLength(15)
                      .IsUnicode(false);
            });

            modelBuilder.Entity<MachineWarranty>(entity => {
                entity.Property(e => e.MachineWarrantyId).HasColumnName("MachineWarrantyID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ServiceTag)
                      .IsRequired()
                      .HasMaxLength(20)
                      .IsUnicode(false);

                entity.Property(e => e.WarrantyExpiration).HasColumnName("date");

                entity.Property(e => e.WarrantyProviderId).HasColumnName("WarrantyProviderID");

                entity.HasOne(d => d.WarrantyProvider)
                      .WithMany(p => p.MachineWarranty)
                      .HasForeignKey(d => d.WarrantyProviderId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_WarrantyProvider");
            });

            modelBuilder.Entity<SupportLog>(entity => {
                entity.Property(e => e.SupportLogId).HasColumnName("SupportLogID");

                entity.Property(e => e.SupportLogEntry)
                      .IsRequired()
                      .IsUnicode(false);

                entity.Property(e => e.SupportLogEntryDate).HasColumnType("date");

                entity.Property(e => e.SupportLogUpdatedBy)
                      .IsRequired()
                      .HasMaxLength(50)
                      .IsUnicode(false);

                entity.Property(e => e.SupportTicketId).HasColumnName("SupportTicketID");

                entity.HasOne(d => d.SupportTicket)
                      .WithMany(p => p.SupportLog)
                      .HasForeignKey(d => d.SupportTicketId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("FK_SupportTicket");
            });
            
            modelBuilder.Entity<SupportTicket>(entity => 
            {
                entity.Property(e => e.SupportTicketId).HasColumnName("SupportTicketID");
            });
        }
    }
}