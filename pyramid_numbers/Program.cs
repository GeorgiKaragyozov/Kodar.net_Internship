using System;

namespace pyramid_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, space;

            do
            {
                Console.Write("Please enter a number between 1 to 9 : ");
                num = Convert.ToInt32(Console.ReadLine());
                space = num - 1;
            }
            while (num <= 0 || num > 9);
            {
                for (int i = 1; i <= num; i++)
                {
                    for (space = 1; space <= num - i; space++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = num - i + 1; j <= num; j++)
                    {
                        Console.Write(j + " ");
                    }
                    for (int k = (num - 1); k >= num - i + 1; k--)
                    {
                        Console.Write(k + " ");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}

