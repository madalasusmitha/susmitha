using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emas.Models
{
   public interface Interface
    {
        Employ GetEmploy(int id);
        List<Employ> displayDetails();
        bool AddEmploy(Employ emp1);
    }
}
