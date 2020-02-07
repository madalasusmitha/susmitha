using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsedemo
{
    class Convertdemo 
    {
        static void Main()
        {
            string s = Convert.ToString(true);
            Console.WriteLine(s);
            s = Convert.ToString(1.23);
            Console.WriteLine(s);
            bool b = Convert.ToBoolean(1);

        }  
    }

}
