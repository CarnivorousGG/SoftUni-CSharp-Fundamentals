using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //Read a text, split it into words and distribute them into 3 lists.
    // Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
    // Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
    // Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
    //Use the following separators between the words: , ; : . ! ( ) &quot; &#39; \ / [ ] space


namespace _04.SplitByWordCasing
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            List<string> textInput = Console.ReadLine() //get input
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries) //adding the separators
                .ToList(); 

            //creating 3 new lists for the results
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();

            foreach (string word in textInput)
            {

                bool isMixed = false;
                bool isUpper = false;
                bool isLower = false;

                foreach (char letter in word)
                {
                    if (!char.IsLetter(letter)) // if the char/letter isn't a unicode character, move word to mixerd
                    {
                        isMixed = true;
                    }
                    else if (char.IsLower(letter)) //check for lower casing and update
                    {
                        isLower = true;
                    }
                    else if (char.IsUpper(letter)) //check for upper and update
                    {
                        isUpper = true;
                    }
                }


                //add each word to the results when a condition is met
                if (isMixed) //contains mixed words
                {
                     mixedCase.Add(word);
                }
                else if (!isLower) //if the letters arent lower 
                {
                    upperCase.Add(word); //add to uppercase list
                }
                else if (!isUpper) //if the letters arent upper
                {
                    lowerCase.Add(word); //add to lowercase list
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            //print the list
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
