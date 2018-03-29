using System;

namespace ErmTest.Models.Entities
{
    public class Employment
    {
        public int Id { get; set; }

        public int MarkingPeriodId { get; set; }

        public int SchoolId { get; set; }

        public int FacultyId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string EmploymentStatusExplanation { get; set; }

        public EmploymentStatus Status { get; set; }

        public string Title { get; set; }

        public string OfficeLocation { get; set; }

        public virtual Faculty Teacher { get; set; }

        public virtual School School { get; set; }

        public virtual MarkingPeriod MarkingPeriod { get; set; }
    }
}