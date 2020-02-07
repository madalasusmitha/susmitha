using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caf
{
    class converter
    {
        int val1;
        int val2;
        public int Val1
        {
            get
            {
                return val1;

            }
            set
            {
                val1 = value;
            }
        }
        public int Val2
        {
            get
            {
                return val2;

            }
            set
            {
                val2 = value;
            }
        }
        public converter()
        {

        }
        public converter(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;

        }
        public int add(int num1,int num2)
        {
            return num1 + num2;
        }
        public void  swap(  ref int  num1, ref int num2)
        {
            
            num1 = num1+num2;
            num2 = num1-num2;
            num1 = num1-num2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
        public void  sub(int num1,int num2,out int res)

        {
            res=(num1 - num2);
            Console.WriteLine(res);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           converter cf = new converter();
      
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            cf.swap( ref x,ref y);
           int  result =cf.add(x, y);
            Console.WriteLine(result);
            cf.sub(x, y,out int res);
            Console.WriteLine();
            Console.WriteLine(x + " " + y);
            Console.ReadKey();

        }
    }
}
