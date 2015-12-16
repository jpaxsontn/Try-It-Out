using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_97
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = GenerateNumbers(10);
            var reversedNumbers = Reverse(numbers);
            Console.WriteLine("Numbers reversed:");
            PrintNumbers(reversedNumbers);
            Console.ReadKey();
        }

        static int[] GenerateNumbers(int howMany)
        {
            Console.WriteLine("Enter " + howMany + " numbers");
            int counter = 0;
            int[] numbers = new int[howMany];
            while (counter < howMany)
            {
                var inputNumber = Console.ReadLine();
                int validatedNumber;
                if (!Int32.TryParse(inputNumber, out validatedNumber))
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
                else
                {
                    numbers[counter] = validatedNumber;
                    counter++;
                }
            }

            return numbers;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (var iNumber in numbers)
            {
                Console.WriteLine(iNumber);
            }
        }

        static int[] Reverse(int[] numbers)
        {
            int[] reversedNumbers = new int[numbers.Length];
            for (var iCounter = numbers.Length - 1; iCounter >= 0; iCounter--)
            {
                reversedNumbers[numbers.Length - 1 - iCounter] = numbers[iCounter];
            }

            return reversedNumbers;
        }
    }
}
