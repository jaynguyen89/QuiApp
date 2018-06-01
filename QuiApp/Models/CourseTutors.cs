using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class CourseTutors
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StaffId { get; set; }
        public DateTime NominatedDate { get; set; }
        public bool IsHeadTutor { get; set; }
        public bool? IsActive { get; set; }

        public Courses Course { get; set; }
        public Staffs Staff { get; set; }
    }
}
