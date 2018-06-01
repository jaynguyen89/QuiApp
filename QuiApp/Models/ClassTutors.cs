using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class ClassTutors
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StaffId { get; set; }
        public DateTime AssignedDate { get; set; }
        public bool? IsActive { get; set; }

        public Classes Class { get; set; }
        public Staffs Staff { get; set; }
    }
}
