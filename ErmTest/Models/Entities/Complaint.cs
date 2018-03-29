using System;

namespace ErmTest.Models.Entities
{
    public class Complaint
    {
        public int Id { get; set; }

        public int PlaintiffId { get; set; }

        public int DefendantId { get; set; }

        public ComplaintType Type { get; set; }

        public string Detail { get; set; }

        public DateTime SubmisssionDate { get; set; }

        public virtual Person Defendant { get; set; }

        public virtual Person Plaintiff { get; set; }

        public virtual Verdict Verdict { get; set; }
    }
}