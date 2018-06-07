using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string AnswerOption { get; set; }
        public bool? IsCorrect { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Questions Question { get; set; }
    }
}
