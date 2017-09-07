using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBuilding

{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            Console.WriteLine("Greetings. Would you like to create a story?(y or n)");
            string ans = Console.ReadLine().ToLower();
            if ((ans == "y") || (ans == "yes"))
            {
                Console.WriteLine("Great, let's get started.  You will make a series of choices and I will build a story for you as we go.");
            }
            else
            {
                Console.WriteLine("Creating stories can be fun. Come back whenever you want to play.");
                return;
            }
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine().ToLower();
            name = name.Substring(0,1).ToUpper() + name.Substring(1);
            Console.WriteLine("Nice to meet you " + name);
            Console.WriteLine("What is your story about?");
            string storySubject = Console.ReadLine();

            string finalWord = Console.ReadLine();

        }
    }
}
