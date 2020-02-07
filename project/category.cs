using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
     abstract class category
    {
       
            public string category_id { get; set; }
            string category_name { get; set; }
            string brief_details { get; set; }

            public category(string category_id, string category_name, string brief_details)
            {
                this.category_id = category_id;
                this.category_name = category_name;
                this.brief_details = brief_details;

            }
        }
}
