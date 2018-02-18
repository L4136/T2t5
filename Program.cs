using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2t5
{
    class Program
    {
        static void Main(string[] args)
        {
            int trunkHeight = 2;
            
            Console.Write("Give a number: ");
            int height = System.Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < height; i++)
            {
                int j;
                if (i < (height - trunkHeight))
                {
                    j = i;
                }
                else
                {
                    j = 0;
                }
                printSpace(height, j, trunkHeight);
                
                printStar(j);
                Console.WriteLine();
            }
        }

        static void printSpace(int height, int i, int trunkHeight)
        {
            int whitespace = height - i - trunkHeight - 1;
            for (int j = 0; j < whitespace; j++)
            {
                Console.Write(" ");
            }
        }

        static void printStar(int i)
        {
            int stars = 2 * i + 1;
            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }
        }
    }
    
}
