using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzTest
{
    public class FizzBuzzGenerator
    {

        public void GenerateFizzBuzz()
        {
            var numbers = Enumerable.Range(1, 100);

            foreach (var item in numbers)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }

                if (item % 3 == 0)
                {

                    Console.WriteLine("Fizz");
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }

                else
                {
                    Console.WriteLine(item);

                }

            }
        }
    }
}