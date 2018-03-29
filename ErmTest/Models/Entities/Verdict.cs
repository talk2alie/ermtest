using System;

namespace ErmTest.Models.Entities
{
    public class Verdict
    {
        public int ComplaintId { get; set; }

        public VerdictFinding Finding { get; set; }

        public VerdictAction Action { get; set; }

        public DateTime ConclusionDate { get; set; }

        public virtual Complaint Complaint { get; set; }
    }
}