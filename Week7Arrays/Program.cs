using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "sandwich with cheese", "yogurt", "bananana", "bacon", "egg", };

            food[3] = "sausage";
            food[1] = "kefir";

            Console.WriteLine("Menu: ");

            for(int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Pick an item (enter a number from 1 to 5");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"You have chosen {food[userChoice]}");

        }
    }
}
