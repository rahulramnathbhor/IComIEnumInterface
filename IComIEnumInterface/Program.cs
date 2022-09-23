using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComIEnumInterface
{
    internal class Program
    {
        public class Player : IComparable
        {
            private int run;
            private string name;
            public Player(int run, string name)
            {
                this.run = run;
                this.name = name;
            }

            public int CompareTo(object obj)
            {
                Player p = (Player)obj;

                if (this.run > p.run)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public override string ToString()
            {
                return $"Runs {run}  name {name}";
            }
        }
        public class Team : IEnumerable
        {
            Player[] players;
            public Team()
            {
                players = new Player[3];
                players[0] = new Player(10000, "Rohit");
                players[1] = new Player(12000, "Virat");
                players[2] = new Player(24000, "Dhoni");
            }

            public IEnumerator GetEnumerator()
            {
                return players.GetEnumerator();
            }
        }
        public class program
        {
            static void Main(string[] args)
            {
                Team team = new Team();

                foreach (Player p in team)
                {
                    Console.WriteLine(p);
                }



                Player p1 = new Player(14000, "Rohit");
                Player p2 = new Player(12000, "Virat");
                Player p3 = new Player(24000, "Dhoni");

                int result = p1.CompareTo(p2);
                if (result == 1)
                {
                    Console.WriteLine("Virat have more run than Rohit");
                }
                else
                {
                    Console.WriteLine("Virat have less run than Rohit");
                }
            }

        }
    }
}



