using System;

namespace ErmTest.Models.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public int SyllabusId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public SyllabusEvent Type { get; set; }

        public virtual Syllabus Syllabus { get; set; }
    }
}