using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_FizzBuzz_01102016
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code will play the Fizz Buzz game.
            // A number is selected to be "fizz" and another number to be "buzz".
            // Players will also choose a number to count to.
            // Players (in this case, the computer) displays numbers in order, until a number is reached
            // that is divisible by "fizz".  If the number is divisible by "fizz" then "fizz" is stated.
            // If a number that is divisible by "buzz" is reached, then "buzz" is stated.
            // If the number is divisible by both "fizz" and "buzz", then "fizz buzz" is stated.

            Console.WriteLine("Do you know how to play Fizz Buzz?");
            Console.WriteLine("I will show you.");
            Console.WriteLine();

            int userFizz = 0;
            int userBuzz = 0;
            int countTo = 0;

            do
            {
                Console.Write("Please choose a number between 1 and 10 to be Fizz: ");
                userFizz = int.Parse(Console.ReadLine());
            } while ((userFizz < 1) || (userFizz > 10));

            do
            {
                Console.Write("Please choose a different number between 1 and 10 to be Buzz: ");
                userBuzz = int.Parse(Console.ReadLine());
            } while ((userBuzz < 1) || (userBuzz > 10) || (userBuzz == userFizz));

            do
            {
                Console.Write("Now choose a number between 10 and 100 that we should count to: ");
                countTo = int.Parse(Console.ReadLine());
            } while ((countTo < 10) || (countTo > 100));
            Console.WriteLine();

            //Console.WriteLine($"fizz {userFizz} buzz {userBuzz} count {countTo}");
            for (int i = 1; i <= countTo; i++)
            {
                if (i % userFizz == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % userBuzz == 0)
                {
                    Console.Write("Buzz");
                }
                if ((i % userFizz != 0) && (i % userBuzz != 0))
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}
