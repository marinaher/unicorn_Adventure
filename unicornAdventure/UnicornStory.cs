using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicornAdventure
{
    class UnicornStory
    {
        Player playerOne;

        public UnicornStory()
        {
            this.playerOne = new Player();
        }

        public void RunUnicornStory()
        {
            Console.WriteLine("You're in a forest and come across a unicorn. \n");
            Console.WriteLine("{0} Do you pet it, try to ride it, shoot it, take a selfie or none of the above?", playerOne.getName());
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "pet it":
                    Console.WriteLine("The unicorn enjoys your company and loves to be petted.");
                    Console.ReadLine();
                    break;
                case "try to ride it":
                    Console.WriteLine("You scared the unicorn away!");
                    Console.ReadLine();
                    break;
                case "shoot it":
                    Console.WriteLine("Good shot! But you have just killed the only unicorn in the world.... jerk");
                    Console.ReadLine();
                    break;
                case "take a selfie":
                    break;
                default:
                    Console.WriteLine("Unicorns don't that.");
                    Console.ReadLine();
                    break;
            }
            if (userChoice == "shoot it")
            {
                Console.WriteLine("Not sure why you would do that.");
                Console.ReadLine();
            }
            else if (userChoice == "pet it")
            {
                Console.WriteLine("The unicorn wants to be your friend");
                Console.ReadLine();
            }
        }
    }
}
