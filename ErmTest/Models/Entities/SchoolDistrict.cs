using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class SchoolDistrict
    {
        public int Id { get; set; }

        public int CountyId { get; set; }

        public string Name { get; set; }

        public string OfficeAddress { get; set; }

        public string OfficeCity { get; set; }

        public string PrimaryPhoneNumber { get; set; }

        public string SecondaryPhoneNumber { get; set; }

        public string PrimaryEmailAddress { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public virtual County County { get; set; }

        public virtual ICollection<School> Schools { get; set; }

        public SchoolDistrict()
        {
            Schools = new HashSet<School>();
        }
    }
}