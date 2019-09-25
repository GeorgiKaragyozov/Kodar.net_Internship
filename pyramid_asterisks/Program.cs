using System;

namespace pyramid_asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m, j = 0;

            string symbol = "";

            do
            {
                Console.Write("Please enter a number between 1 to 9 : ");
                m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Please enter symbol for pyramid : ");
                symbol = Console.ReadLine();
            }
            while (m <= 0 || m > 9);
            {
                for (i = 0; i < m; i++)
                {
                    for (j = 1; j <= (m - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= (2 * i - 1); j++)
                    {
                        Console.Write(symbol);
                    }

                    //create a new Line
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
    }
}

