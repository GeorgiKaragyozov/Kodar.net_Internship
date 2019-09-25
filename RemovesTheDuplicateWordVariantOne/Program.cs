using System;
using System.Collections.Generic;
using System.Linq;

namespace RemovesTheDuplicateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NameList = new List<string>
            {
                "Ivan",
                "Ivan",
                "Dobri",
                "Dimitur",
                "Georgi",
                "Dimitur"
            };

            foreach (var item in NameList.Distinct())
            {
                Console.WriteLine("The name is " + item);
            }

            Console.ReadKey();
        }
    }
}
