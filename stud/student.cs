using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud
{
   public abstract class student
    {
        protected string name;
        protected string id;
        protected int grade;
        public   abstract bool Ispassed(int grade);
        public student(string name,string id,int grade)
        {
            this.name = name;
            this.id = id;
            this.grade = grade;
                
        }
       
    }
    class ug : student
    {
        public ug(string name, string id, int grade):base(name,id,grade)
        {

        }
        public override bool Ispassed(int grade)
        {
            if(grade>=70)
            {
                Console.WriteLine("passed");
                return true;

            }
            else
            {
                Console.WriteLine("failed");
                return false;

            }
        }

    }
    class pg:student
    {
        public pg(string name, string id, int grade) : base(name, id, grade)
        {

        }
        public  override bool Ispassed(int grade)
        {
            
            if (grade >= 80)
            {
                Console.WriteLine("pass");
                return true;
                
            }
            else
            {
                Console.WriteLine("failed");
                return false;


            }

        }

    }

}
