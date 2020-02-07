using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Handsonmvc.Models
{
    public class User
    {
        [Required(ErrorMessage = "plz enter Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email ID")]
        public string email { get; set; }
        [Required(ErrorMessage = "Dob is required")]

        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Mobile no  is required")]
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "select country",AllowEmptyStrings =false)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
}
}
