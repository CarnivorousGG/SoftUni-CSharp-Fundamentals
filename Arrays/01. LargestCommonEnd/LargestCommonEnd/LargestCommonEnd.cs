using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
// Exercise: Read two arrays of words and find the length of the largest common end(left or right).
namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            //create first array, split input by whitespace and remove empy entries
            var firstInput = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            //same as above
            var secondInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int count = 0; //create a counter for each equal world
            int lenght = Math.Min(firstInput.Length, secondInput.Length); //get the smallest array in lenght to use in our for loop



            for (int i = 0; i < lenght-1; i++)
            {
                if (firstInput[i] == secondInput[i]) //check if elements are equal
                {
                    count++; //count the equal elements
                }
                
               
            }

            Console.WriteLine(count); //print the number of equal elements
        }
    }
}
