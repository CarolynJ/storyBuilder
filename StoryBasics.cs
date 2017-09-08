using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBuilding
{
    public class StoryBasics
    {
        private string playerName;
        public string PlayerName
        {
            get { return this.playerName; }
        }
        private string storySubject;
        public string StorySubject
        {
            get { return this.storySubject; }
        }
        private string color;
        public string Color
        {
            get { return this.color; }
        }
        private string title;
        public string Title
        {
            get { return this.title; }
        }

        public void Display()
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
            playerName = Console.ReadLine().ToLower();
            playerName = playerName.Substring(0, 1).ToUpper() + playerName.Substring(1);
            Console.WriteLine("Nice to meet you " + playerName);

            Console.WriteLine("What is your story about? Choose a general theme (enter # of your choice");
            Console.WriteLine("(1) Cooking");
            Console.WriteLine("(2) Eating");
            Console.WriteLine("(3) Traveling");
            Console.WriteLine("(4) Learning");
            Console.WriteLine("(5) Building");

            storySubject = Console.ReadLine();

            if (storySubject == "1")
            {
                cookingMenu meal = new cookingMenu();
                meal.Display();
            }

            Console.WriteLine("Select a color (enter # of your choice:");
            Console.WriteLine("(1) purple");
            Console.WriteLine("(2) slate grey");
            Console.WriteLine("(3) red");
            Console.WriteLine("(4) green");
            Console.WriteLine("(5) yellow");

            color = Console.ReadLine();

            string finalWord = Console.ReadLine();

        }
    }
}
