using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class PartQuestions
    {
        public int Id { get; set; }
        public int PartId { get; set; }
        public int QuestionId { get; set; }
        public bool? IsActive { get; set; }

        public Parts Part { get; set; }
        public Questions Question { get; set; }
    }
}
