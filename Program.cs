using System;

namespace translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string userInput = Console.ReadLine();
            string vowels = "aeiouAEIOU";
            string consonants = "";

            // Check vowel first index
            if (vowels.Contains(userInput[0]))
            {
                Console.WriteLine(userInput + "yay");
            }
            else
            {
                // find index
                int vowelIndex = -1;
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (vowels.Contains(userInput[i]))
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                // final inputs
                string endconsonant = userInput.Substring(0, vowelIndex);
                string newString = userInput.Substring(vowelIndex) + endconsonant + "ay";
                Console.WriteLine("Pig Latin: " + newString);
            }
        }
    }
}

