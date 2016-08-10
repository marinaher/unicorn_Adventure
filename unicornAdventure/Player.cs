using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicornAdventure
{
    class Player
    {
        string name;

        public Player()
        {
        }

        public Player(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            Console.WriteLine("What is your name?");
            this.name = Console.ReadLine();
            return this.name;
        }
    }
}
