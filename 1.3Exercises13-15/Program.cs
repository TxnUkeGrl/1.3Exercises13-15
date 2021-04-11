using System;

namespace _1._3Exercises13_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 13 Description
            //    Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.

            Console.WriteLine("Hello User, Give me a number to count down from!");
            bool Again = true;

            do
            {
                if (Again != true)
                {
                    Console.WriteLine("Okay, Give me another number!");
                }

                Again = false;

                int EntryNumber = int.Parse(Console.ReadLine());
                for (int i = EntryNumber; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nWould you like to continue? (y/n)");
            }

            while (Console.ReadLine().ToLower() == "y");



            //EXERCISE 14 Description
            //    Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.

            Console.WriteLine("AWESOME! Now please give me a number to square!");

            bool Again2 = true;

            do
            {
                if (Again2 != true)
                {
                    Console.WriteLine("Okay! What number would you like to try?");
                }
                Again2 = false;

                int EntryNumber = int.Parse(Console.ReadLine());

                for (int i = 1; i <= EntryNumber; i++)
                {
                    Console.Write((i * i) + " ");
                }

                Console.WriteLine("\nWould you like to try another number? (y/n)");
            }

            while (Console.ReadLine().ToLower() == "y");


            //EXERCISE 15 Description
            //    Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to that number.

            Console.WriteLine("Wasn't that cool?! What number should we cube?");
            
            bool Again3 = true;

            do
            {
                if (Again3 != true)
                {
                    Console.WriteLine("Type in a different number you'd like to try.");
                }
                Again3 = false;

                int EntryNumber = int.Parse(Console.ReadLine());
               
                for (int i = 1; i <= EntryNumber; i++)
                {
                    Console.Write((i * i * i) + " ");
                }
                
                Console.WriteLine("\nWanna go again? (y/n)");
                
            }

            while (Console.ReadLine().ToLower() == "y");
        }
    }
}
