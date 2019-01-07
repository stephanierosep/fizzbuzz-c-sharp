using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
     
        {
            bool isDivisibleByThree;
            bool isDivisibleByFive;

            for (int i = 1; i <= 100; i++)
            {
                isDivisibleByThree = (i % 3 == 0);
                isDivisibleByFive = (i % 5 == 0);

                if (isDivisibleByThree && isDivisibleByFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isDivisibleByThree) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (isDivisibleByFive)
                { 
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
