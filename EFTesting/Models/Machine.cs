using System.Collections.Generic;
namespace EFTesting.Models
{
    public class Machine
    {
        public Machine()
        {
            SupportTicket = new HashSet<SupportTicket>();
        }
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string GeneralRole { get; set; }
        public int OperatingSysId { get; set; }
        public MachineType MachineType { get; set; }
        public OperatingSys OperatingSys { get; set; }
        public ICollection<SupportTicket> SupportTicket { get; set; }
    }
}