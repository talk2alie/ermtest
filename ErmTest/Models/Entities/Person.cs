using System;
using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string SchoolSystemIdentity { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public Sex Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public double HeightInFeetInches { get; set; }

        public double WeightInPounds { get; set; }

        public virtual ICollection<SchoolIdentity> SchoolIdentities { get; set; }

        public virtual ICollection<Relative> Relatives { get; set; }

        public virtual ICollection<Attendance> AttendanceRecords { get; set; }

        public virtual ICollection<PersonContact> PersonContacts { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        public virtual ICollection<Thumbnail> Thumbnails { get; set; }

        public virtual ICollection<Complaint> FiledComplaints { get; set; }

        public virtual ICollection<Complaint> DefendingComplaints { get; set; }

        public Person()
        {
            SchoolIdentities = new HashSet<SchoolIdentity>();
            Relatives = new HashSet<Relative>();
            AttendanceRecords = new HashSet<Attendance>();
            PersonContacts = new HashSet<PersonContact>();
            PersonAddresses = new HashSet<PersonAddress>();
            Thumbnails = new HashSet<Thumbnail>();
            FiledComplaints = new HashSet<Complaint>();
            DefendingComplaints = new HashSet<Complaint>();
        }
    }
}