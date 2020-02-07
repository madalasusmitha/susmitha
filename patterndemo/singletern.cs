using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterndemo
{
    class singletern
    {
        static int count = 0;
        public static singletern instance=null;//memory is not allocated so object does not exist
        public  static singletern Getinstance
            {
            get
            {
                if (instance == null) return new singletern();
                else return instance;
            }
            }


        private  singletern()//constructor private
        {
            count++;
            Console.WriteLine(count);
        }
        public void printdetails(string w)
        {
            
            Console.WriteLine(w);
        }
    }
}
