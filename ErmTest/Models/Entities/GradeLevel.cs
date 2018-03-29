using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class GradeLevel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<SchoolGradeLevel> SchoolGradeLevels { get; set; }

        public GradeLevel()
        {
            SchoolGradeLevels = new HashSet<SchoolGradeLevel>();
        }
    }
}