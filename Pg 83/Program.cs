using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_83
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] secondArray = new int[firstArray.Length];

            for(var iIndex = 0; iIndex < firstArray.Length; iIndex++)
            {
                secondArray[iIndex] = firstArray[iIndex];
            }

            for (var iIndex = 0; iIndex < firstArray.Length; iIndex++)
            {
                Console.WriteLine("firstArray[" + iIndex + "] = " + firstArray[iIndex]);
                Console.WriteLine("secondArray[" + iIndex + "] = " + secondArray[iIndex]);
            }

            Console.ReadKey();
        }
    }
}
