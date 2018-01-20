using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    //Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
    // After two numbers are summed, the obtained result could be equal to some of its neighbors and should be
    //summed as well (see the examples below).
    // Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).


namespace _03.SumAdjacentEqualNumbers
{
    internal class StartProgram
    {
        private static void Main(string[] args)

        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var index = 0; //we need to create this variable in order to check and manipulate the index

            while (index < numbers.Count-1)
            {
                if (numbers[index] == numbers[index + 1]) //if the current index is equal to the next
                {

                    numbers[index] = numbers[index] + numbers[index + 1]; //change the current's index value to their sum
                    numbers.RemoveAt(index + 1); //remove the second index in order to check for other adjacent equl pairs
                    if (index > 0) 
                    {
                        index = 0; //when we receive and index bigger index, we need to set its value to zero,
                                   //otherwise it will not be able to check the newly formed elements and will give a false result
                    }
                }
                else
                {
                    index++; //when the condition is met, increase the index value to continue scanning the list
                }
            }

            Console.WriteLine(string.Join(" ", numbers)); //print the result
        }
    }
}
