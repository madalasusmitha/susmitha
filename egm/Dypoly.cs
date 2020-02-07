using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egm
{
     abstract class Dypoly
    {
      //  public  virtual void display()
       // {
        //    Console.WriteLine("display the A class");

        //}
      public   abstract void display();
    }
    class B:Dypoly
    {
        public override void display()
        {
            Console.WriteLine("display the  B class");
        }
    }


    class c:Dypoly

{
    public override void display()
    {
        Console.WriteLine("display the  C  class");
    }

}
}