using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuiApp.Models.ManageViewModels {
    public class UserInformationViewModel {
        [Required]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Give Name")]
        public string GiveName { get; set; }

        [Display(Name = "Personal ID")]
        public string UserCode { get; set; }

        public string StatusMessage { get; set; }
    }
}
