using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Students
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public double? Mark { get; set; }
        public bool IsActive { get; set; }

        public AspNetUsers User { get; set; }
    }
}
