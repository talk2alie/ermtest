using ErmTest.EntityConfigurations;
using ErmTest.Models;
using ErmTest.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ErmTest.DbContexts
{
    public class ErmTestDbContext : DbContext
    {
        public DbSet<AcademicYear> AcademicYears { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Assessment> Assessments { get; set; }

        public DbSet<Attendance> AttendanceRecords { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<Complaint> Complaints { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<County> Counties { get; set; }

        public DbSet<Employment> Employments { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Event> ClassEvents { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<GradeLevel> GradeLevels { get; set; }

        public DbSet<MarkingPeriod> MarkingPeriods { get; set; }

        public DbSet<Objective> Objectives { get; set; }

        public DbSet<Period> Periods { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Policy> ClassPolicies { get; set; }

        public DbSet<Relative> Relatives { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<SchoolDistrict> SchoolDistricts { get; set; }

        public DbSet<SchoolIdentity> SchoolIdentities { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Semester> Semesters { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Syllabus> Syllabi { get; set; }

        public DbSet<TextBook> TextBooks { get; set; }

        public DbSet<Thumbnail> Thumbnails { get; set; }

        public DbSet<Verdict> Verdicts { get; set; }

        public ErmTestDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.HasKey(personAddress => new { personAddress.PersonId, personAddress.AddressId });
            });

            modelBuilder.Entity<PersonContact>(entity =>
            {
                entity.HasKey(personContact => new { personContact.PersonId, personContact.ContactId });
            });

            modelBuilder.Entity<Verdict>(entity =>
            {
                entity.HasKey(verdict => verdict.ComplaintId);
            });

            modelBuilder.Entity<ClassTextBook>(entity => entity.ToTable("ClassTextBooks"));
            modelBuilder.Entity<PersonAddress>(entity => entity.ToTable("PersonAddresses"));
            modelBuilder.Entity<PersonContact>(entity => entity.ToTable("PersonContacts"));
            modelBuilder.Entity<SchoolGradeLevel>(entity => entity.ToTable("SchoolGradeLevels"));
        }
    }
}