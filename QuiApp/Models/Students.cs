using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Students
    {
        public Students()
        {
            ClassStudents = new HashSet<ClassStudents>();
            CourseStudents = new HashSet<CourseStudents>();
            PartAttempts = new HashSet<PartAttempts>();
            QuestionAttempts = new HashSet<QuestionAttempts>();
            StudentTests = new HashSet<StudentTests>();
            TestAttempts = new HashSet<TestAttempts>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public double? WeightedMark { get; set; }
        public bool? IsMarkEditted { get; set; }
        public string Notes { get; set; }
        public bool? IsActive { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<ClassStudents> ClassStudents { get; set; }
        public ICollection<CourseStudents> CourseStudents { get; set; }
        public ICollection<PartAttempts> PartAttempts { get; set; }
        public ICollection<QuestionAttempts> QuestionAttempts { get; set; }
        public ICollection<StudentTests> StudentTests { get; set; }
        public ICollection<TestAttempts> TestAttempts { get; set; }
    }
}
