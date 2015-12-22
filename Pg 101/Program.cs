using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_101
{
    class Program
    {
        static void Main(string[] args)
        {

            Initialize();
            var fibSequence = GetFibonacciSequenceInput();
            PrintResults(fibSequence);

            Console.ReadKey();

        }

        static void Initialize()
        {
            Console.WriteLine("Fibonacci Sequence for first 10 sequence numbers");
            PrintResults(10);
        }


        //Not a good use case for recursion
        static int GetFibonacciSequenceInput()
        {
            Console.WriteLine("Enter the Fibonacci sequence you would like to display");
            int validNumber;
            while(!Int32.TryParse(Console.ReadLine(), out validNumber) || validNumber == 0)
            {
                if(validNumber < 1)
                {
                    validNumber = GetFibonacciSequenceInput();
                }
                return validNumber;
            }

            return validNumber;
        }


        //Standard loop
        static void PrintResults(int sequenceNumber)
        {
            for (int iSequence = 1; iSequence <= sequenceNumber; iSequence++)
            {
                Console.Write(GetFibonacciNumber(iSequence) + " ");
            }

            Console.WriteLine();
        }


        //Decent case for recursion but expensive on the CPU. For big numbers you will want to solve a different way.
        static int GetFibonacciNumber(int number)
        {
            if(number == 0)
            {
                return 0;
            } if (number == 1)
            {
                return 1;
            }

            return GetFibonacciNumber(number - 1) + GetFibonacciNumber(number - 2);
        }
    }
}
