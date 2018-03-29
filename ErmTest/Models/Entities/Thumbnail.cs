using System;

namespace ErmTest.Models.Entities
{
    public class Thumbnail
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public byte[] Image { get; set; }

        public DateTime AdditionDate { get; set; }

        public virtual Person Person { get; set; }
    }
}