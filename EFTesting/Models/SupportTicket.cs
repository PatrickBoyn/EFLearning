using System.Collections.Generic;
namespace EFTesting.Models
{
    public class SupportTicket
    {
        public SupportTicket()
        {
            SupportLog = new HashSet<SupportLog>();   
        }
    }
}