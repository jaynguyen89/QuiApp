using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Staffs
    {
        public Staffs()
        {
            ClassTutors = new HashSet<ClassTutors>();
            Classes = new HashSet<Classes>();
            CourseTutors = new HashSet<CourseTutors>();
            Courses = new HashSet<Courses>();
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public bool? IsLecturer { get; set; }
        public string Office { get; set; }
        public string Notes { get; set; }
        public bool? IsActive { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<ClassTutors> ClassTutors { get; set; }
        public ICollection<Classes> Classes { get; set; }
        public ICollection<CourseTutors> CourseTutors { get; set; }
        public ICollection<Courses> Courses { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
