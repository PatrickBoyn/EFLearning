using System.Collections.Generic;
namespace EFTesting.Models
{
    public class MachineType
    {
        public MachineType()
        {
            Machine = new HashSet<Machine>();
        }
    }
}