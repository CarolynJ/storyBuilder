using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryBuilding
{
    public class cookingMenu
    {
        public void Display()
        {
            Console.WriteLine("How do you plan on preparing your next meal? Will it be ...");
            Console.WriteLine("1. Straight from the refridgerator");
            Console.WriteLine("2. Baked in the oven");
            Console.WriteLine("3. Cooked on the stovetop");
            Console.WriteLine("4. It's in the slow cooker");
            Console.WriteLine("5. Eating out");
            string mealPrep = Console.ReadLine();
        }
    }
}
