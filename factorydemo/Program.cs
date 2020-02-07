using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiclefactory obj = new concretevehiclefactory();
            Factory myvehicle = obj.GenerateVehicle("bike");
            myvehicle.manufacture(10);
            myvehicle = obj.GenerateVehicle("car");
            myvehicle.manufacture(10);
        } 
    }
}
