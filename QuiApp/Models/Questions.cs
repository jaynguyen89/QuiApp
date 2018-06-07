using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
            PartQuestions = new HashSet<PartQuestions>();
            QuestionAttempts = new HashSet<QuestionAttempts>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public string VideoEmbed { get; set; }
        public bool? IsReserved { get; set; }
        public bool? IsRepeatable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Courses Course { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<Answers> Answers { get; set; }
        public ICollection<PartQuestions> PartQuestions { get; set; }
        public ICollection<QuestionAttempts> QuestionAttempts { get; set; }
    }
}
