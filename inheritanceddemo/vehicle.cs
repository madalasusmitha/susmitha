using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceddemo
{
   abstract  class vehicle
    {
       protected string color;
        public vehicle()
        {
            this.color = "blue";
        }
        public vehicle(string clr)
        {
            this.color = clr;
            Console.WriteLine("parametre constructor");
        }
        public abstract void fillfuel();
        




        public  virtual   void start()
        {
            Console.WriteLine("vehicle started");

        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");
        }
        
    }
    class Bus:vehicle
    {
        int seating;
        int speed;
        public Bus():base("Red")
        {
            this.seating = 70;
            this.speed = 30;
        }
        public override void fillfuel()
        {
            Console.WriteLine("fillfuld");
        }

        public void run()
        {
            Console.WriteLine(this.color +"bus is running"+this.seating);

        }
        public override  void start()

        {
            Console.WriteLine("srtttyty");
        }
    }
    class Car:vehicle
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 20;
            this.type = "bmw";
        }
        public override void fillfuel()
        {
            Console.WriteLine("fillfuld");
        }
        public Car(string clor,int spd,string tye):base(" hfg")
        {
            this.speed = spd;
            this.type = tye;
        }
        public void drive()
        {
            Console.WriteLine(this.color+"car is driving"+this.speed);
        }
    }

}
