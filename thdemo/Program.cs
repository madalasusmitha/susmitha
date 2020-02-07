using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            Threadclass th = new Threadclass();
            Thread th1 = new Thread(th.counteven);
            Thread th2 = new Thread(th.countodd);
            th1.Priority = ThreadPriority.Lowest;
            th2.Priority = ThreadPriority.Highest;
            Console.WriteLine("main ends");
            th1.Start();
            th2.Start();
            th1.Suspend();
            Console.WriteLine("thread got suspended");

        }
    }
}
