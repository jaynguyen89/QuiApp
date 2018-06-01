using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuiApp.Models {

    public class Student : ApplicationUser {
        public float Mark { get; set; }
        public bool IsMarkEditted { get; set; }
    }
}
