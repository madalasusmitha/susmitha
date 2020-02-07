using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandsonValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="plz enter id")]
        [DisplayName("Employee Id")]
        public int ID { get; set; }
        [Required(ErrorMessage = "plz enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "name should be")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public String Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string uname { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd",ErrorMessage = "password mismatch")]
        public string cpwd { get; set; }




    }
}
