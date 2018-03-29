using System;
using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class MarkingPeriod
    {
        public int Id { get; set; }

        public int SemesterId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual ICollection<Employment> Employments { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public MarkingPeriod()
        {
            Employments = new HashSet<Employment>();
            Enrollments = new HashSet<Enrollment>();
        }
    }
}