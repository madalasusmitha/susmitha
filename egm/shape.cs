using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egm
{
    class shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("a shape can be drawn");
        }
        public void draw(int i)
        {
            this.length = i;
            Console.WriteLine("a shape can be drawn");
        }
        public void draw(int i,int j)
        {
            Console.WriteLine("a shape can be drawn");
        }
        public void draw(int i,int j,int k)
        {
            Console.WriteLine("a shape can be drawn");

        }
        public void draw(int i, int j, int k,string name)
        {
            Console.WriteLine("a shape can be drawn");

        }

    }
}
