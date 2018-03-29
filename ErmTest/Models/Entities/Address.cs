using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        public Address()
        {
            PersonAddresses = new HashSet<PersonAddress>();
        }
    }
}