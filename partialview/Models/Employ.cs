using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace partialview.Models
{
    public enum Department
    {
        It,accounts,Insurance,Healthcare
    }
    public class Employ
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public Department Dept { get; set; }
        public  Employ()
            {

            }
        public Employ(int id,string name,string email,)


    }
}
