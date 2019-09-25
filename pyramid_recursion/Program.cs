using System;

namespace pyramid_recursion
{
    class Program
    {
        static void PrintLine(int row, int n)
        {
            if (row > n)
            {
                return;
            }

            PrintWhitespace(n - row);
            PrintNumbers(n - row + 1, n);
            PrintNumbersBackwards(n - row, n, n - 1);

            Console.WriteLine();

            PrintLine(row + 1, n);
        }

        static void PrintWhitespace(int whiteNum)
        {
            if (whiteNum == 0)
            {
                return;
            }

            Console.Write("  ");

            PrintWhitespace(whiteNum - 1);
        }

        static void PrintNumbers(int number, int n)
        {
            if (number > n)
            {
                return;
            }

            Console.Write(number + " ");

            PrintNumbers(number + 1, n);
        }

        static void PrintNumbersBackwards(int number, int n, int printNumber)
        {
            if (number + 1 == n)
            {
                return;
            }

            Console.Write(printNumber + " ");

            PrintNumbersBackwards(number + 1, n, printNumber - 1);
        }

        static void PrintPyramid()
        {
            int num, space;

            do
            {
                Console.Write("Please enter a number between 1 to 9 : ");
                num = Convert.ToInt32(Console.ReadLine());
                space = num - 1;
            }
            while (num <= 0 || num > 9);

            PrintLine(1, num);
        }

        static void Main(string[] args)
        {
            PrintPyramid();

            Console.ReadKey();
        }
    }
}
