using System;

namespace ErmTest.Models.Entities
{
    public class Attendance
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public int ClassId { get; set; }

        public AttendanceStatus Status { get; set; }

        public DateTime Date { get; set; }

        public string Note { get; set; }

        public virtual Class Class { get; set; }

        public virtual Person Person { get; set; }
    }
}