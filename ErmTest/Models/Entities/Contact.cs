using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        public ContactType Type { get; set; }

        public string Detail { get; set; }

        public virtual ICollection<PersonContact> PersonContacts { get; set; }

        public Contact()
        {
            PersonContacts = new HashSet<PersonContact>();
        }
    }
}