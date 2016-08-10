using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicornAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicornStory story = new UnicornStory();
            story.RunUnicornStory();
            Console.WriteLine("The End!");
            Console.ReadLine();
        }
    }
}
