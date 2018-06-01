using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class CourseStudents
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public DateTime EnroledDate { get; set; }
        public bool? IsActive { get; set; }

        public Courses Course { get; set; }
        public Students Student { get; set; }
    }
}
