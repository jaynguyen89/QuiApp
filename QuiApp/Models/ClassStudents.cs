using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class ClassStudents
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public DateTime JointDate { get; set; }
        public bool? IsActive { get; set; }

        public Classes Class { get; set; }
        public Students Student { get; set; }
    }
}
