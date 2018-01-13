using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// TASK:   Write a program to find all prime numbers in range[1…n]. Implement the algorithm called “Sieve of Eratosthenes”:
//https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes. Steps in the “Sieve of Eratosthenes” algorithm:
//1. Assign primes[0…n] = true
//2. Assign primes[0] = primes[1] = false
//3. Find the smallest p, which holds primes[p] = true
// Print p(it is prime)
// Assign primes[2 * p] = primes[3 * p] = primes[4 * p] = … = false
//4. Repeat for the next smallest p &lt; n.

namespace _04.SieveOfEratosthenes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //read the number of elements

            bool[] isPrime = new bool[n + 1]; //make an array of booleans

            for (int i = 0; i < isPrime.Length; i++)
            {
                isPrime[i] = true; //change value to all bools to true
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (isPrime[i]) 
                {
                    for (int j = i * i; j < isPrime.Length; j += i)
                    {
                        isPrime[j] = false; // if the number is odd, change bool value to false
                    }
                }
            }

            List<int> result = new List<int>(); 
            for (int i = 2; i < isPrime.Length; i++)
            {
                if (isPrime[i]) // if number is prime
                {
                   result.Add(i); //add the result to the list
                }
            }

            Console.WriteLine(string.Join(" ", result)); //print
        }
    }
}
 