using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class QuestionAttempts
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public int TestAttemptId { get; set; }
        public bool IsCorrect { get; set; }
        public short? TimeTaken { get; set; }

        public Questions Question { get; set; }
        public Students Student { get; set; }
        public TestAttempts TestAttempt { get; set; }
    }
}
