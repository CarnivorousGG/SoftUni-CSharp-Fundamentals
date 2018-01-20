using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class StartProgram
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split('|').ToArray();
            List<string> result = new List<string>();
            Array.Reverse(input);

            foreach (var token in input)
            {
                string[] final = token.Split(' ');

                foreach (var number in final)
                {
                    if (number != " ")
                    {
                        result.Add(number);
                    }

                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
