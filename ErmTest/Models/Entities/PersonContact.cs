using System;

namespace ErmTest.Models.Entities
{
    public class PersonContact
    {
        public int PersonId { get; set; }

        public int ContactId { get; set; }

        public DateTime AdditionDate { get; set; }

        public bool IsCurrent { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Person Person { get; set; }
    }
}