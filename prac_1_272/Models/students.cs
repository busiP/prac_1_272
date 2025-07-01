using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace prac_1_272.Models
{
    public class students //STEP 1: CREATE MODEL WITH PROPERTIES
    {
        [Display(Name = "Student Number")]
        public string StudentNum { get; set; }

        [Display(Name = "Fist Name")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        public string Surname { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }
    }
}