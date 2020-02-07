using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exap
{
    abstract class player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public abstract void DisplayPlayerstatistic();

        public player(string name, string teamname, int noofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
    }
    class cricketplayer : player
    {
        int totalrunsscored;
        int noofwicketstaken;
        public cricketplayer(string name, string teamname, int noofmatches, int totalrunsscored, int noofwicketstaken) : base(name, teamname, noofmatches)
        {
            this.totalrunsscored = totalrunsscored;
            this.noofwicketstaken = noofwicketstaken;

        }
        public override void DisplayPlayerstatistic()
        {
            Console.WriteLine("cricket player details");
            Console.WriteLine(this.name + " " + this.teamname + noofmatches + " " + " " + this.noofwicketstaken);
        }
    }
    class Hockeyplayer : player
    {
        string position;
        int noofgoals;
        public Hockeyplayer(string name, string teamname, int noofmatches, string position, int noofgoals) : base(name, teamname, noofmatches)
        {

            {
                this.position = position;
                this.noofgoals = noofgoals;
            }
        }

        public override void DisplayPlayerstatistic()
        {
            Console.WriteLine("hockeyplayer details");
            Console.WriteLine(this.name + " " + this.teamname + " " + this.position + "" + this.noofgoals);

        }
    }
}



