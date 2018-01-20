using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
namespace _05.Sort_Numbers
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
