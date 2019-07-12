using System;
using System.Collections.Generic;

namespace dictionary_about_words
{
    class Program
    {
        static void Main(string[] args)
        {



            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            //can use: var excitedWord = new Dictionary<string, string>(); also for above line

            //You want to track the following about each word:
            //      word, definition, part of speech, example sentence

            // Add each of the 4 bits of data about the word to the Dictionary
            {
                excitedWord.Add("word", "excited");
                excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
                excitedWord.Add("part of speech", "adjective");
                excitedWord.Add("example sentence", "I am excited to learn C#!");

            }

            //Iterate your list of dictionaries and output the data, 
            // You can use the two foreach() loops below to help you start your iteration.

            // Iterate the List of Dictionaries
            foreach (KeyValuePair<string, string> word in excitedWord)

            {
                // Iterate the KeyValuePairs of the Dictionary
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }

    }

}




