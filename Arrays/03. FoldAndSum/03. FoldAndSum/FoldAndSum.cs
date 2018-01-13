using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //TASK: Read an array of 4* k integers, fold it like shown below, and print the sum of the upper and lower two rows(each
    //holding 2 * k integers):

    //Create the first row after folding: the first k numbers reversed, followed by the last k numbers reversed.
    // Create the second row after folding: the middle 2* k numbers.
    // Sum the first and the second rows.


namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4; //take 1/4 of the array in order to create the rows

            int[] leftTopRow = numbers.Take(k).ToArray(); // take 1/4 of the element/s
            int[] bottomRow = numbers.Skip(k).Take(k * 2).ToArray(); // take bottom half
            int[] rightTopRow = numbers.Skip(k * 3).Take(k).ToArray(); // skip 3/4 of the array and take the remainder

            Array.Reverse(leftTopRow); //reversing the left/right arrays
            Array.Reverse(rightTopRow);

            int[] result = new int[k * 2]; //  r

            for (int i = 0; i < k; i++)
            {
                result[i] = bottomRow[i] + leftTopRow[i]; //sum the leftop and middle indexes
                result[i + k] = bottomRow[i + k] + rightTopRow[i]; //do the same for right side

            }
            Console.WriteLine(string.Join(" ", result)); //print the summed result




        }
    }
}