using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class StudentTests
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TestId { get; set; }
        public double? Mark { get; set; }
        public bool IsEditted { get; set; }
        public string EdittedBy { get; set; }
        public DateTime MarkedOn { get; set; }
        public DateTime EdittedOn { get; set; }

        public Students Student { get; set; }
        public Tests Test { get; set; }
    }
}
