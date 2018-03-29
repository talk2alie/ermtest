using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Class
    {
        public int Id { get; set; }

        public int SectionId { get; set; }

        public int SubjectId { get; set; }

        public int PeriodId { get; set; }

        public int FacultyId { get; set; }

        public string Title { get; set; }

        public DaysOfWeek Days { get; set; }

        public virtual Faculty Teacher { get; set; }

        public virtual Period Period { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Section Section { get; set; }

        public virtual Syllabus Syllabus { get; set; }

        public virtual ICollection<Attendance> AttendanceRecords { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }

        public virtual ICollection<ClassTextBook> ClassTextBooks { get; set; }

        public Class()
        {
            AttendanceRecords = new HashSet<Attendance>();
            Assessments = new HashSet<Assessment>();
            ClassTextBooks = new HashSet<ClassTextBook>();
        }
    }
}