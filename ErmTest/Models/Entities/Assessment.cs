using System;

namespace ErmTest.Models.Entities
{
    public class Assessment
    {
        public int Id { get; set; }

        public int ClassId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime AssignmentDate { get; set; }

        public DateTime DueDate { get; set; }

        public virtual Class Class { get; set; }
    }
}