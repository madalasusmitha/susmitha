using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceddemo
{
    
        class parent
        {
             protected  internal int a;                                                       
             protected  internal string b;
          
            public int A1 { get => a; set => a = value; }
            public string B { get => b; set => b = value; }
            public void getvalues(int x,string y)
            {
                this.A1 = x;
                this.B = y;
            }
                
            public void Display()
            {
                Console.WriteLine(this.A1 + " " + this.B);

            }
        }
        class child:parent
        {
           protected int c;
            public void calculate(int num)
            {
                c = this.a + num;
                Console.WriteLine(c);
            }

        }
        class Grandchild:child
        {
            int  d;
            public void multiply(int num2)
            {
                this.d = num2;
                Console.WriteLine(this.d * this.c * this.a);

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            // parent obj = new parent();
            // child ob = new child();
            // Grandchild obj1 = new Grandchild();
            // obj.getvalues(12,"ch");
            //obj.Display();
            // obj.getvalues(23, "asp.net");
            // obj.Display();
            // ob.calculate(30);
            // obj1.getvalues(30, "navya");
            // obj1.Display();
            // obj1.calculate(5);
            // obj1.multiply(5);
            // Console.ReadKey();
            Car c = new Car("yellow",160,"standard");
           // vehicle v = new vehicle();
            Bus bu = new Bus();
            c.start();
            c.stop();
            c.drive();
            c.fillfuel();
            //v.start();
            ///v.stop();
            bu.run();
            bu.start();
            bu.stop();
            bu.fillfuel();


            Console.ReadKey();

        }
    }
}
namespace Demoprotected
{
    class Exchild : inheritanceddemo.parent
    {

        public void ExDisplay()
        {
            Console.WriteLine(this.a + " " + this.b);
        }
    }
}