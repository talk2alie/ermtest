using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class TextBook
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ClassTextBook> ClassTextBooks { get; set; }
    }
}