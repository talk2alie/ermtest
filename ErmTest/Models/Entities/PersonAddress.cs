using System;

namespace ErmTest.Models.Entities
{
    public class PersonAddress
    {
        public int PersonId { get; set; }

        public int AddressId { get; set; }

        public DateTime AdditionDate { get; set; }

        public bool IsCurrent { get; set; }

        public virtual Address Address { get; set; }

        public virtual Person Person { get; set; }
    }
}