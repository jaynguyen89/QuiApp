using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QuiApp.Models {
    
    public class ApplicationUser : IdentityUser {
        public string GiveName { get; set; }
        public string MiddleName { get; set; }
        public string FamilyName { get; set; }
        public string UserCode { get; set; }
        public bool IsActive { get; set; }
    }
}
