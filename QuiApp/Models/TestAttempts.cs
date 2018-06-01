using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class TestAttempts
    {
        public TestAttempts()
        {
            PartAttempts = new HashSet<PartAttempts>();
            QuestionAttempts = new HashSet<QuestionAttempts>();
        }

        public int Id { get; set; }
        public int TestId { get; set; }
        public int StudentId { get; set; }
        public byte? Attempt { get; set; }
        public double? AttemptMark { get; set; }
        public short? TimeTaken { get; set; }

        public Students Student { get; set; }
        public Tests Test { get; set; }
        public ICollection<PartAttempts> PartAttempts { get; set; }
        public ICollection<QuestionAttempts> QuestionAttempts { get; set; }
    }
}
