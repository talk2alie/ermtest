using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class School
    {
        public int Id { get; set; }

        public int SchoolDistrictId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PrimaryPhoneNumber { get; set; }

        public string SecondaryPhoneNumebr { get; set; }

        public string PrimaryEmailAddress { get; set; }

        public string SecondaryEmailAddress { get; set; }

        public SchoolOwnership Ownership { get; set; }

        public SchoolLevel Level { get; set; }

        public byte[] Crest { get; set; }

        public virtual SchoolDistrict District { get; set; }

        public virtual ICollection<SchoolGradeLevel> SchoolGradeLevels { get; set; }

        public virtual ICollection<Employment> Employments { get; set; }

        public virtual ICollection<SchoolIdentity> Identities { get; set; }

        public School()
        {
            SchoolGradeLevels = new HashSet<SchoolGradeLevel>();
            Employments = new HashSet<Employment>();
            Identities = new HashSet<SchoolIdentity>();
        }
    }
}