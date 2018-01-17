using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();


            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }
            }

            result.Reverse();

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
