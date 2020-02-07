using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Handsonmvc.Models;

namespace Handsonmvc.Repositories
{
    public class userrepository
    {
        public static List<User> list=new List<User>()
        {
            new User(){  name = "susmitha",
                Country = "india",
                uname = "sush",
                Password = "1234"}
              
        };
        public userrepository()
        {
           
        }
        public void Add(User item)
        {
            list.Add(item);
            
        }
        public User validate(string Uname,string pwd)
        {
            foreach(var item in list)
            {
                if(item.uname==Uname && item.Password==pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
