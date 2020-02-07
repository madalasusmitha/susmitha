using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excep
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num / 2);
                try
                {

                    int[] a = new int[] { 2, 3, 4, 5, 6 };
                    Console.WriteLine(a[5]);
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Source);
                }
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("ended");
            }
            Console.ReadKey();

        }
    }
}
