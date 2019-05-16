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
            
        }
    }
}