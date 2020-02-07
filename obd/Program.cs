using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obd
{

        class bike
        {
        string name;
            string color;
            public void setdetails(string name, string color)
            {

            }
            public void Startengine()
            {
                Console.WriteLine("bike started at " + DateTime.Now);
            }
            public void fillgas(int litres)
            {
                Console.WriteLine("bike filled with" + litres + "litres");

            }
            public static Travel(int distance, int speed)
            {
                int time = (int)(distance / speed);
                Console.WriteLine("you will reach the distance in " + time);
                return (time);

            }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            bike enfield = new bike();

            enfield.Startengine();
            enfield.fillgas(10);
            




        }
    }
}
