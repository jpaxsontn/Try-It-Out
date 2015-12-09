using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_85
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int[] copyOfNumbersArray = new int[numbersArray.Length];

            int total = 0;

            foreach(var iNumber in numbersArray)
            {
                total += iNumber;
                //copyOfNumbersArray[I don't have the index]
            }

            float average = (float)total / numbersArray.Length;

            Console.WriteLine("Sum of numbers in array = " + total);
            Console.WriteLine("Average of numbers in array = " + average);

            Console.ReadKey();
        }
    }
}
