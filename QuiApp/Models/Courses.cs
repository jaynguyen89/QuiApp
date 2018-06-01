using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Classes = new HashSet<Classes>();
            CourseStudents = new HashSet<CourseStudents>();
            CourseTutors = new HashSet<CourseTutors>();
            Questions = new HashSet<Questions>();
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public int StaffId { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool? IsActive { get; set; }

        public Staffs Staff { get; set; }
        public ICollection<Classes> Classes { get; set; }
        public ICollection<CourseStudents> CourseStudents { get; set; }
        public ICollection<CourseTutors> CourseTutors { get; set; }
        public ICollection<Questions> Questions { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
