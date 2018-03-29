using ErmTest.Models;
using ErmTest.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErmTest.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(person => person.Id)
                .HasName("PK_Person");
            builder.Property(person => person.Id)
                .HasColumnName("PersonId");
            builder.HasMany(person => person.FiledComplaints)
                .WithOne(complaint => complaint.Plaintiff);
            builder.HasMany(person => person.DefendingComplaints)
                .WithOne(complaint => complaint.Defendant);
            builder.HasDiscriminator<string>("PersonType")
                .HasValue<Student>("Student")
                .HasValue<Faculty>("Faculty");
        }
    }
}