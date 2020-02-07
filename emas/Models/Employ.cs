using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace emas.Models
{
    public class Employ
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage="Length can be maximum 10")]
        public string Name { get; set; }
        [Required]
        //[RegularExpression("[a-z]",ErrorMessage ="Invalid")]
        [DisplayName("company Mail")]
        [Remote(action: "IsMailExists", controller: "Employ")]
        [Validatedomain(allowdomain:"cts.com")]
      
        public string Email { get; set; }
        public string dept { get; set; }
        public Employ()
        {

        }

        public Employ(int Id, string Name, string Email, string dept)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.dept = dept;
        }
    }
}
