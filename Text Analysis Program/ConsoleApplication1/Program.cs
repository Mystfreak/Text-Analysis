using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace TextAnalyzer
{
    class Program
    {
        private static string answer;
        private static string file;
        private static string value;

        static void Main(string[] args)
        {

            // Accepting the users input
            Console.WriteLine("Do you want to enter the text via the keyboard?");
            Console.WriteLine("Yes or No");
            answer = Console.ReadLine();

            int totalV = 0;
            int totalC = 0;
            int wordCount = 0, index = 0;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var consonants = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            int countUpper = 0, countLower = 0;

            // Analyzing the written sentence
            if (answer == "Yes")
            {
                Console.WriteLine("Enter a sentence");
                string sentence = Console.ReadLine();

                // The number of words in the sentence
                while (index < sentence.Length)
                {
                    // Check if the char is part of a word
                    while (index < sentence.Length && !char.IsWhiteSpace(sentence[index]))
                        index++;
                    wordCount++;
                    // Skip whitespace until next word
                    while (index < sentence.Length && char.IsWhiteSpace(sentence[index]))
                        index++;
                }

                // Counting number of vowels and consonants
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (vowels.Contains(sentence[i]))
                    {
                        totalV++;
                    }
                    else if (consonants.Contains(sentence[i]))
                    {
                        totalC++;
                    }
                }

                // Counting how many uppercase and lowercase letters there are
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (char.IsUpper(sentence[i]))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(sentence[i]))
                    {
                        countLower++;
                    }
                }

                // Displaying all the functions results
                Console.WriteLine("Number of words in the sentence: {0}", wordCount);
                Console.WriteLine("Your total number of vowels is: {0}", totalV);
                Console.WriteLine("Your total number of consonants is: {0}", totalC);
                Console.WriteLine("Total number of Uppercase letters: {0}", countUpper);
                Console.WriteLine("Total number of Lowercase letters: {0}", countLower);

                // Output the frequency of individual letters
                int[] c = new int[(int)char.MaxValue];

                foreach (char t in sentence)
                {
                    c[t]++;
                }

                for (int i = 0; i < char.MaxValue; i++)
                {
                    if (c[i] > 0 &&
                        char.IsLetterOrDigit((char)i))
                    {
                        Console.WriteLine("Letter: {0} Frequency: {1}",
                            (char)i, c[i]);
                    }
                }
                Console.ReadLine();
            }



            if (answer == "No")
            {
                Console.WriteLine("Do you want to read in the text from a file?");
                Console.WriteLine("Yes or No");
                file = Console.ReadLine();
            }

            // Opening the text file
            if (file == "Yes")
            {
                Process.Start(@"C:\Users\Kat\Documents\sentence.txt");
                value = File.ReadAllText(@"C:\Users\Kat\Documents\sentence.txt");
                Console.WriteLine(value);
                Console.ReadLine();

                while (index < value.Length)
                {
                    // Check if the char is part of a word
                    while (index < value.Length && !char.IsWhiteSpace(value[index]))
                        index++;
                    wordCount++;
                    // Skip whitespace until next word
                    while (index < value.Length && char.IsWhiteSpace(value[index]))
                        index++;
                }

                // Checking how many vowels and consonants
                for (int i = 0; i < value.Length; i++)
                {
                    if (vowels.Contains(value[i]))
                    {
                        totalV++;
                    }
                    else if (consonants.Contains(value[i]))
                    {
                        totalC++;
                    }
                }

                // Counting number of uppercase and lowercase letters
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsLower(value[i]))
                    {
                        countLower++;
                    }

                    else if (char.IsUpper(value[i]))
                    {
                        countUpper++;
                    }
                    
                    

                    // Displaying the results in the console
                    Console.WriteLine("Number of words in the sentence: {0}", wordCount);
                    Console.WriteLine("Your total number of vowels is: {0}", totalV);
                    Console.WriteLine("Your total number of consonants is: {0}", totalC);
                    Console.WriteLine("Total number of Uppercase letters: {0}", countUpper);
                    Console.WriteLine("Total number of Lowercase letters: {0}", countLower);

                    // Output the frequency of individual letters
                    int[] c = new int[(int)char.MaxValue];

                    foreach (char t in value)
                    {
                        c[t]++;
                    }

                    for (i = 0; i < char.MaxValue; i++)
                    {
                        if (c[i] > 0 &&
                            char.IsLetterOrDigit((char)i))
                        {
                            Console.WriteLine("Letter: {0} Frequency: {1}",
                                (char)i, c[i]);
                        }
                    }
                    Console.ReadLine();
                }

            }
        }
    }
}


