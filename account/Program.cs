using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account
{
    class account
    {
        public int acno;
        public string name;
        public string actype;
        public int amount;
        public double balance;
        
        public account(int acno,string name,string actype,int amount,double balance )
        {
            this.acno = acno;
            this.name = name;
            this.actype = actype;
            this.amount = amount;
            this.balance = balance;

        }
   
        public void deposit( int amount)
        {
            balance = balance + amount;
            Console.WriteLine("money is deposited" +balance);
        }
        public void withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("money is deducted" +balance);
        }
        
       

    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the account no");
            int acno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the account holder name:");
            string  name =Console.ReadLine();
            Console.WriteLine("enter the account type:");
            string actype = Console.ReadLine();
            Console.WriteLine("enter the account amount: ");
            int amount = int.Parse(Console.ReadLine());
            double balance = 50000;




            account ac = new account(acno,name,actype,amount,balance);


            Console.WriteLine("deposit/withdrwal");
            char b = Convert.ToChar(Console.ReadLine());
            if (b == 'd')
            {

                ac.deposit(amount);
            }
            else if (b == 'w')
            {

                ac.withdraw(amount);
            }
            else
                Console.WriteLine("Enter val;id transation type");

            // ac.deposit(600);
            //ac.withdraw(50);
            Console.ReadKey();


            

        }
    }
}
