using System;
using System.Collections.Generic;
namespace EFTesting.Models
{
    public partial class SupportTicket
    {
        public SupportTicket()
        {
            SupportLog = new HashSet<SupportLog>();   
        }
        public int SupportTicketId { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime? DateResolved { get; set; }
        public string IssueDescription { get; set; }

    }
}