using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace emas.Models
{
    public class Employr:Interface
    {
        private List<Employ> emp;
        public Employr()
        {
            emp = new List<Employ>() { new Employ ( 1, "dsfk","vijay@gmail.com","csf"),
            new Employ ( 2, "insurance","susmitha@gmail.com","csf"),
            new Employ ( 3, "dsfk","dsfgdsg@gmail.com","csf")};
        }
        public Employ GetEmploy(int id)
        {
            Employ e = emp.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

           
            return e;
        }
        public List<Employ>displayDetails()
        {
            return emp;
        }
        public bool AddEmploy(Employ emp1)
        {
            emp1.Id = emp.Max(e => e.Id)+1;
            emp.Add(emp1);
            return true;
        }
    }
}
