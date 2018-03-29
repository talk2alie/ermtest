using System;
using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Semester
    {
        public int Id { get; set; }

        public int AcademicYearId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }

        public virtual ICollection<MarkingPeriod> MarkingPeriods { get; set; }

        public Semester()
        {
            MarkingPeriods = new HashSet<MarkingPeriod>();
        }
    }
}