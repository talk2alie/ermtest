using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class SchoolGradeLevel
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }

        public int GradeLevelId { get; set; }

        public virtual ICollection<Section> Sections { get; set; }

        public virtual GradeLevel GradeLevel { get; set; }

        public virtual School School { get; set; }

        public SchoolGradeLevel()
        {
            Sections = new HashSet<Section>();
        }
    }
}