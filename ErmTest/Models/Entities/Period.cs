using System;
using System.Collections.Generic;

namespace ErmTest.Models.Entities
{
    public class Period
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual ICollection<Class> Classes { get; set; }

        public Period()
        {
            Classes = new HashSet<Class>();
        }
    }
}