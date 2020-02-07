using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVarWithDtypes
{
    class Program
    {
        string name;//instance var
        static double salary;//static var
        static void Main(string[] args)
        {
            int i=10;//local var
            int[] a = new int[4] { 12, 13, 14, 15 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            object o1 = 100;
            o1 = "ram";
            o1 = 'a';
            o1 = 12.3;
            int k = 50;
            string name = "Madhu";
            Console.WriteLine("name:{0} Age{1}", name, k);
            Console.ReadKey();           

        }
    }
}
