using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HandsonValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage = "username is Required")]
        public string uname { get; set; }

        [Required(ErrorMessage = "password is Required")]
        public string pwd { get; set; }
    }
}
