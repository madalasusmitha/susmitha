using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("E:\\Madhu");
            di.Create();
            di.CreateSubdirectory("mydir");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }
            FileInfo[] fi = di.GetFiles();
            Console.WriteLine("****************************");
            foreach (FileInfo x in fi)
            {
                Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            }

            // FileStream fs = new FileStream(@"E:\\Madhu\mydir\bu.txt", FileMode.OpenOrCreate, FileAccess.Write);
            // StreamWriter sw = new StreamWriter(fs);
            // sw.WriteLine("welcome");
            // for (int i= 0;i<2;i++)
            // {
            //     string s = Console.ReadLine();
            //    sw.WriteLine(s);
            //
            // }
            // sw.Close();
            // fs.Close();
            //  FileStream fs1 = new FileStream(@"E:\\Madhu\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //  StreamReader sr= new StreamReader(fs1);
            //  string s;
            //  while((s=sr.ReadLine())!=null)
            //  {
            //      Console.WriteLine(s);
            //  }
            //  sr.Close();
            // fs1.Close();
            //FileStream fs1 = new FileStream(@"E:\\Madhu\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            // BinaryWriter sr= new BinaryWriter(fs1);
            //int i = 10;
            //char ch = 'd';
            //string f = "hello";
            //sr.Write(i);
            //sr.Write(ch);
            //sr.Write(f);
            //sr.Close();
            //fs1.Close();
            FileStream s1 = new FileStream(@"E:\\Madhu\mydir\e.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(s1);
                int g= br.ReadInt32();
            char y = br.ReadChar();
            string z = br.ReadString();
            Console.WriteLine(g + " " + y + " " + z);
            br.Close();
            s1.Close();

            Console.ReadKey();



        }
    }
}
