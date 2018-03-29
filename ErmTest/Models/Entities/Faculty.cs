using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Faculty : Person
    {
        public virtual ICollection<Class> Classes { get; set; }

        public virtual ICollection<Employment> Employments { get; set; }

        public virtual Section SponsoredSection { get; set; }

        public Faculty()
        {
            Classes = new HashSet<Class>();
            Employments = new HashSet<Employment>();
        }
    }
}