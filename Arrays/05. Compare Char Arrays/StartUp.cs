using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TASK : Compare two char arrays lexicographically (letter by letter).
    //Print the them in alphabetical order, each on separate line.
namespace _05.Compare_Char_Arrays
{
    class StartUp
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            char[] secondArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

            if (firstArray.Length == secondArray.Length) // if equal lenght
            {
                if (firstArray[0] < secondArray[0]) //check which index is smaller in lox sorting
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
            else if (firstArray.Length > secondArray.Length) //if the 1st array is bigger, it wins
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }

        }
    }
}
