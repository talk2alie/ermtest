using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Class> Classes { get; set; }

        public Subject()
        {
            Classes = new HashSet<Class>();
        }
    }
}