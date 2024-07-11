using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Rows in the Pattern : ");
            int numberOfRows = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = numberOfRows; i >= 1; i--)
            {
                PatternInnerLooop(i);
                Console.WriteLine();
            }
        }

        static void PatternInnerLooop(int outerLoopIterator)
        {
            for (int i = 1; i <= outerLoopIterator; i++)
                Console.Write("*");
        }
    }
}
