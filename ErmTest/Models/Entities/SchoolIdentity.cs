using System;

namespace ErmTest.Models.Entities
{
    public class SchoolIdentity
    {
        public int Id { get; set; }

        public int SchoolId { get; set; }

        public int PersonId { get; set; }

        public string Identification { get; set; }

        public DateTime AssignmentDate { get; set; }

        public virtual Person Person { get; set; }

        public virtual School School { get; set; }
    }
}