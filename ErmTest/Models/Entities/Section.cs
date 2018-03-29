using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Section
    {
        public int Id { get; set; }

        public int SponsorId { get; set; }

        public int PresidentId { get; set; }

        public int SchoolGradeLevelId { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public virtual Faculty Sponsor { get; set; }

        public virtual Student President { get; set; }

        public virtual SchoolGradeLevel GradeLevel { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Class> Classes { get; set; }

        public Section()
        {
            Enrollments = new HashSet<Enrollment>();
            Classes = new HashSet<Class>();
        }
    }
}