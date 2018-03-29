namespace ErmTest.Models.Entities
{
    public class ClassTextBook
    {
        public int Id { get; set; }

        public int TextBookId { get; set; }

        public int ClassId { get; set; }

        public virtual TextBook TextBook { get; set; }

        public virtual Class Class { get; set; }
    }
}