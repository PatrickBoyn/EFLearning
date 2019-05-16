using System.Collections.Generic;
namespace EFTesting.Models
{
    public partial class WarrantyProvider
    {
        public WarrantyProvider()
        {
            MachineWarranty = new HashSet<MachineWarranty>();   
        }

        public int WarrantyProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? SupportExtention { get; set; }
        public string SupportNumber { get; set; }
        public ICollection<MachineWarranty> MachineWarranty { get; set; }
    }
}