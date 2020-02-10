using System;

namespace Lab4.Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");

            for (int i = 0; i < words.Length; i++) 
            {
                string translatedString = PigLatin(words[i]);
                Console.Write(translatedString + " ");
            } 

            
           
        }
        static string PigLatin(string sentence)
        {
            string firstLetter = string.Empty;
            string remainderOfWord = string.Empty;
            string vowels = "AEIOUaeiou";
                
            int currentLetter;

            foreach (string word in sentence.Split())
            {
                string firstLetter1 = sentence.Substring(0, 1);
                remainderOfWord = sentence.Substring(1, sentence.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    sentence = remainderOfWord + firstLetter + "ay";
                }
                else
                {
                    sentence = word + "way";
                }
            }
            return sentence.ToLower();
        }
    }
}

