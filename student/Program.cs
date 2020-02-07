using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class students
    {
        public string name { get; set; }
        private string branch;
        private int rollno;
        private int sem;
        private int marks;

        public int Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }

        }
        public String Branch
        {
            get
            {
                return branch;
            }
            set
            {
                branch=value;
            }

        }
        public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                 sem=value;
            }

        }
        public int Marks
        {
            get
            {
                return marks ;
            }
            set
            {
                marks = value;
            }

        }

        public students()
        {
            this.sem = 3;
            this.branch = "cse";
            this.rollno = 0;
            this.name = " ";
            this.marks = 0;

        }
        public students(string name,int marks,string  branch,int sem)
        {
            this.name = name;
            this.marks = marks;
            this.sem = sem;
            this.branch = branch;
        }

        public void Accept()
        {
            
            Console.WriteLine("accept student details");
         

             


        }
        public void  Display()
        {
           // Console.WriteLine("enter the name of student");
           // string nam = Console.ReadLine();

           // Console.WriteLine("enter the sem");
            //int se = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter the branch  of student");
            //string branch = Console.ReadLine();

            //Console.WriteLine("enter the marks of student");
           // int marks = int.Parse(Console.ReadLine());

           // Console.WriteLine(" name of student" +nam);
           // Console.WriteLine("sem"  +se);

           Console.WriteLine("student details displayed");
            Console.WriteLine(this.name + "\n"+this.marks+"\n"+this.rollno+"\n"+this.Branch+"\n" +this.sem+"\n");
            Console.ReadKey();




        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            students std = new students();
            std.Display();
            //std.name = "sush";
            //std.Rollno = 101;
            // std.Branch = "it";
            // std.Sem = 8;
            // std.Marks = 789;

            // std.Accept();

            students std1 = new students("sush", 90, "it", 8);
           
            std1.Display();
            Console.ReadKey();
        }
    }
}
