using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_116
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            Random random = new Random();
            while(input.ToLower() != "quit" && input.ToLower() != "exit")
            {
                Console.WriteLine("Enter the # of dice you would like to roll");
                int numberOfDice = 0;
                input = Console.ReadLine();
                if(Int32.TryParse(input, out numberOfDice) == true)
                {
                    int sumOfDice = 0;
                    for(var iDiceRoll = 1; iDiceRoll <= numberOfDice; iDiceRoll++)
                    {
                        sumOfDice += random.Next(6) + 1;
                    }
                    Console.WriteLine("The sum of {0} dice rolls was {1}", numberOfDice, sumOfDice);
                }
            }
        }
    }
}
