using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AFALXCourse.Lessons.L2
{
    public class L2Conditionalscs
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number: ");
            var number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            var limit1= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            var limit2 = Int32.Parse(Console.ReadLine());
            CheckNumberWithinLimits(number, limit1, limit2);
            CheckIfNumberIsEven(number);

            if (number < 0)
            {
                Console.WriteLine($"mniejze od zera");
            }
            else if(number>=0 && number<=5)
            {
                Console.WriteLine($"w ramach 0 a 5");
            }
            else 
            {
                Console.WriteLine($"powyzej");
            }



        }

        private static void CheckIfNumberIsEven(int number)
        { 
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"The nomber {number} is an odd number.");
            }

        }
        private static void CheckNumberWithinLimits(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.WriteLine($"{number} is smaller than {limit1}");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"The number is greater than {limit2}");
            }
            else
            {
                Console.WriteLine($"The nomber is equal to {limit1} or equal to {limit2} \nor between {limit2}");
            }
        }
    }
}
