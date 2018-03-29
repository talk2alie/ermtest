using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Student : Person
    {
        public virtual ICollection<Grade> Grades { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual Section Section { get; set; }

        public Student()
        {
            Grades = new HashSet<Grade>();
            Enrollments = new HashSet<Enrollment>();
        }
    }
}