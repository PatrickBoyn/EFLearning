using System.Collections.Generic;
namespace EFTesting.Models
{
    public class MachineType
    {
        public MachineType()
        {
            Machine = new HashSet<Machine>();
        }
        public int MachineTypeId { get; set; }
        public string Description { get; set; }
        public ICollection<Machine> Machine { get; set; }
    }
}