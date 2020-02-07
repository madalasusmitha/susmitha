using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorydemo
{
    interface Factory
    {
        void manufacture(int cnt);
    }
    class bike :Factory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing" + cnt);
        }
    }
    class car:Factory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing" + cnt);
        }
    }
      abstract class vehiclefactory
    {
        public abstract void GenerateVehicle(int cnt);
    }
    class concretevehiclefactory:vehiclefactory
    {
        public override void Factory GenerateVehicle(string type)
        {
            switch(type)
            {
                case "bike":
                    new bike();
                    break;
                case "car":
                    new car();
                    break;
                default:
                    Console.WriteLine("factory can produce this");
                    break;

            }
        }

    }
    class demo
    {
    }
}
