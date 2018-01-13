using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    To “rotate an array on the right” means to move its last element first: {1, 2, 3}  {3, 1, 2}.
//Write a program to read an array of n integers(space separated on a single line) and an integer k, rotate the array
//right k times and sum the obtained arrays after each rotation as shown below.

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            var integers = Console.ReadLine() //getting the input
                .Split()
                .Select(int.Parse)
                .ToArray();

            var rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[integers.Length]; //create an array with equal lenght in which we will use to store our sum


            for (int i = 0; i < rotations; i++)
            {

                var lastElement = integers[integers.Length - 1]; // with this algorithm our first element will not be changed, that's why we need a placeholder
                for (int j = integers.Length-1; j > 0; j--)
                {
                    integers[j] = integers[j - 1]; // reversing the elements from right to left
                }
                integers[0] = lastElement; //replace the first element

                for (int s = 0; s < integers.Length; s++) // go through the array
                {
                    sum[s] += integers[s]; //sum every element
                }
            }

            Console.WriteLine(string.Join(" ", sum)); // print the total sum

        }
    }
}
