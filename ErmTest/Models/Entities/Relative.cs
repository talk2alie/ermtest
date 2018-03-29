using System;

namespace ErmTest.Models.Entities
{
    public class Relative
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public Relationship Relationship { get; set; }

        public DateTime AdditionDate { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PrimaryPhoneNumber { get; set; }

        public string SecondaryPhoneNumebr { get; set; }

        public string PrimaryEmailAddress { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public virtual Person Person { get; set; }
    }
}