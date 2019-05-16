using System;

namespace EFTesting.Models
{
    public class MachineWarranty
    {
        public int MachineWarrantyId { get; set; }
        public string ServiceTag { get; set; }
        public DateTime WarrantyExpiration { get; set; }
        public int MachineId { get; set; }
        public int WarrantyProviderId { get; set; }
        public WarrantyProvider WarrantyProvider { get; set; }
    }
}