using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovesTheDuplicateWordVariantTwo
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
                "Ivan",
                "Dimitur",
                "Georgi",
            };

            List<string> finallyList = new List<string>();

            string value;

            for (int i = 0; i < NameList.Count; i++)
            {
                value = NameList[i];

                for (int j = i + 1; j < NameList.Count; j++)
                {
                    if (NameList[j] == value)
                    {
                        NameList.RemoveAt(j);
                    }
                }
            }

            foreach (var item in NameList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

