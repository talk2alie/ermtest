using System;

namespace ErmTest.Models.Entities
{
    public class Enrollment
    {
        public int Id { get; set; }

        public int MarkingPeriodId { get; set; }

        public int SectionId { get; set; }

        public int StudentId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Note { get; set; }

        public EnrollmentStatus Status { get; set; }

        public virtual Student Student { get; set; }

        public virtual Section Section { get; set; }

        public virtual MarkingPeriod MarkingPeriod { get; set; }
    }
}