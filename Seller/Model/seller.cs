using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seller.Model
{
    public class seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string password { get; set; }
        public string Companyname { get; set; }
        public int GSTIN { get; set; }
        public string briefdetails { get; set; }
        public string postal_address { get; set; }
        public string website { get; set; }
        public string emailid { get; set; }
        public int contactnumber { get; set; }


        public seller(int Id, string Name, string password, string Companyname, int GSTIN, string briefdetails, string postaladdress, string website, string email, int contactnumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.password = password;
            this.Companyname = Companyname;
            this.GSTIN = GSTIN;
            this.briefdetails = briefdetails;
            this.postal_address = postal_address;
            this.website = website;
            this.emailid = emailid;
            this.contactnumber = contactnumber;


        }
    }
}

