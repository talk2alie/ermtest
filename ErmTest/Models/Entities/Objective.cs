namespace ErmTest.Models.Entities
{
    public class Objective
    {
        public int Id { get; set; }

        public int SyllabusId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual Syllabus Syllabus { get; set; }
    }
}