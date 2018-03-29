using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class County
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string EducationOfficerFullName { get; set; }

        public string PrimaryPhoneNumber { get; set; }

        public string SecondaryPhoneNumber { get; set; }

        public string PrimaryEmailAddress { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public string OfficeAddress { get; set; }

        public string OfficeCity { get; set; }

        public virtual ICollection<SchoolDistrict> SchoolDistricts { get; set; }

        public County()
        {
            SchoolDistricts = new HashSet<SchoolDistrict>();
        }
    }
}