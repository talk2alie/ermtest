using System;
using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class AcademicYear
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual ICollection<Semester> Semesters { get; set; }

        public AcademicYear()
        {
            Semesters = new HashSet<Semester>();
        }
    }
}