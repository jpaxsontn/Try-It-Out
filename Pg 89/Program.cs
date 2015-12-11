using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_89
{
    class Program
    {
        enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 12");
            int number = 0;

            if(!Int32.TryParse(Console.ReadLine(), out number) || number <= 0 || number > 12)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Using the long method you entered: " + GetMonthLongWay(number));
            Console.WriteLine("Using the short method you entered: " + GetMonthShortWay(number));
            Console.ReadKey();
        }

        public static string GetMonthShortWay(int monthValue)
        {
            string month = Enum.GetName(typeof(Months), monthValue);
            return month;
        }

        public static string GetMonthLongWay(int monthValue)
        {
            string month = null;
            switch ((Months)monthValue)
            {
                case Months.January:
                    month = "January";
                    break;
                case Months.February:
                    month = "February";
                    break;
                case Months.March:
                    month = "March";
                    break;
                case Months.April:
                    month = "April";
                    break;
                case Months.May:
                    month = "May";
                    break;
                case Months.June:
                    month = "June";
                    break;
                case Months.July:
                    month = "July";
                    break;
                case Months.August:
                    month = "August";
                    break;
                case Months.September:
                    month = "September";
                    break;
                case Months.October:
                    month = "October";
                    break;
                case Months.November:
                    month = "November";
                    break;
                case Months.December:
                    month = "December";
                    break;
            }
            return month;
        }
    }
}
