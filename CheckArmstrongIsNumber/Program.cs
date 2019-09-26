using System;
using System.Collections.Generic;

namespace CheckArmstrongIsNumber
{
    class Program
    {
        /// <summary>
        /// Check whether a given number is Armstrong number or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>return bool / true or false</returns>
        private static bool CheckArmstrongNumber(int num)
        {
            double sum = 0;
            int copyNumber, remainder = 0;

            List<int> list = new List<int>();

            copyNumber = num;

            while (num != 0)
            {
                remainder = num % 10;

                list.Add(remainder);
                num = num / 10;
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += Math.Pow(list[i], list.Count);
            }

            if (copyNumber == sum)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int number = 9474;

            Console.WriteLine(CheckArmstrongNumber(number)); 

            Console.ReadKey();
        }
    }
}
