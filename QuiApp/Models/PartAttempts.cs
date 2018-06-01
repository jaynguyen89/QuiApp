using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class PartAttempts
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int StudentId { get; set; }
        public int TestAttemptId { get; set; }
        public double? AttemptMark { get; set; }
        public short? TimeTaken { get; set; }

        public Parts Part { get; set; }
        public Students Student { get; set; }
        public TestAttempts TestAttempt { get; set; }
    }
}
