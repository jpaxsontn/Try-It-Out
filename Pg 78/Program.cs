using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This was a little tricky and took me a little over an hour to figure out.
//Shame on me instead of solving with pencil and paper (Actually thinking about the problem) 
//I tried several different and wrong combos first before I thought through the problem.

namespace Pg_78
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPyramid(11);
            Console.ReadLine();
        }

        public static void PrintPyramid(int height)
        {
            int baseWidth = 0;
            if(height == 1)
            {
                baseWidth = 1;
            }
            else
            {
                baseWidth = (height * 2);
            }

            for(var iHeight = 0; iHeight < height; iHeight++)
            {
                for(var iBaseWidth = 0; iBaseWidth < baseWidth; iBaseWidth++)
                {
                    if(iBaseWidth >= (height - iHeight))
                    {
                        if(iBaseWidth > (height + iHeight))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    else if(baseWidth == height)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
