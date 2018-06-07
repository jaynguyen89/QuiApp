using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Parts
    {
        public Parts()
        {
            PartAttempts = new HashSet<PartAttempts>();
            PartQuestions = new HashSet<PartQuestions>();
        }

        public int Id { get; set; }
        public int TestId { get; set; }
        public byte? PartOrder { get; set; }
        public string PartTitle { get; set; }
        public string PartDescription { get; set; }
        public short? PartDuration { get; set; }
        public double? PartTotalMark { get; set; }
        public bool? IsActive { get; set; }

        public Tests Test { get; set; }
        public ICollection<PartAttempts> PartAttempts { get; set; }
        public ICollection<PartQuestions> PartQuestions { get; set; }
    }
}
