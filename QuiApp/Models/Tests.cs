using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Tests
    {
        public Tests()
        {
            Parts = new HashSet<Parts>();
            StudentTests = new HashSet<StudentTests>();
            TestAttempts = new HashSet<TestAttempts>();
        }

        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ClassId { get; set; }
        public int StaffId { get; set; }
        public DateTime? ActiveOn { get; set; }
        public DateTime? ClosedOn { get; set; }
        public short? TestDuration { get; set; }
        public double? TestTotalMark { get; set; }
        public byte? AllowedAttempts { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool? IsActive { get; set; }

        public Classes Class { get; set; }
        public Courses Course { get; set; }
        public Staffs Staff { get; set; }
        public ICollection<Parts> Parts { get; set; }
        public ICollection<StudentTests> StudentTests { get; set; }
        public ICollection<TestAttempts> TestAttempts { get; set; }
    }
}
