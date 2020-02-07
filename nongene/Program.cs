using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nongene
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(30);
            list.Add(10);
            list.Add(30);
            list.Add('d');
            foreach (int v in list)
                Console.WriteLine(v);

            Queue<string> names = new Queue<string>();
            names.Enqueue("sush");
            names.Enqueue("smityha");
            names.Enqueue("sm");
            foreach (string s in names)
                Console.WriteLine(s);

            Stack<string> st = new Stack<string>();
            st.Push("100");
            st.Push("25");
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Peek());
            foreach (var s in st)
                Console.WriteLine(s);

            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(23);
            hs.Add(32);
            hs.Add(20);
            foreach (int val in hs)
                Console.WriteLine(val);
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "rao");
            dt.Add(2, "radha");
            dt.Add(3, "lakshmi");
            foreach( KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }


            Console.ReadLine();



             
        }
    }
}
