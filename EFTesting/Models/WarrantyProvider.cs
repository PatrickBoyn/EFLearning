using System.Collections.Generic;
namespace EFTesting.Models
{
    public class WarrantyProvider
    {
        public WarrantyProvider()
        {
            MachineWarranty = new HashSet<MachineWarranty>();
        }
    }
}