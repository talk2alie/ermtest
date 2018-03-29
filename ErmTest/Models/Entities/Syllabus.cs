using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Syllabus
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public int AcademicYearId { get; set; }

        public string Title { get; set; }

        public string ClassDescription { get; set; }

        public virtual AcademicYear AcademicYear { get; set; }

        public virtual Class Class { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual ICollection<Objective> Objectives { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }

        public Syllabus()
        {
            Events = new HashSet<Event>();
            Objectives = new HashSet<Objective>();
            Policies = new HashSet<Policy>();
        }
    }
}