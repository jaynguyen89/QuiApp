using System;
using System.Collections.Generic;

namespace QuiApp.Models
{
    public partial class Lecturers
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public AspNetUsers User { get; set; }
    }
}
