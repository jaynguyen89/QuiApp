using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Classes
    {
        public Classes()
        {
            ClassStudents = new HashSet<ClassStudents>();
            ClassTutors = new HashSet<ClassTutors>();
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public int StaffId { get; set; }
        public int CourseId { get; set; }
        public string ClassTitle { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public Courses Course { get; set; }
        public Staffs Staff { get; set; }
        public ICollection<ClassStudents> ClassStudents { get; set; }
        public ICollection<ClassTutors> ClassTutors { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
