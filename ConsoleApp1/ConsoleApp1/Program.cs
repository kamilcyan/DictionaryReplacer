using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            prog.WriteIn();
            prog.Translate();

            Console.ReadLine();
        }

        public void WriteIn()
        {
            Dictionary dictionary = new Dictionary();

            dictionary.AddWords("temp", "temporary");
            dictionary.AddWords("adj", "adjustment");
            dictionary.AddWords("go", "gorilla");
            dictionary.AddWords("name", "John Wick");
            dictionary.AddWords("op", "open");
            dictionary.AddWords("plax", "please");
            dictionary.AddWords("prog", "DictionaryReplacer");
            dictionary.AddWords("goal", "Work");
            dictionary.AddWords("res", "resistance");
            dictionary.AddWords("nud", "send nudes");

            foreach (KeyValuePair<string, string> kvp in dictionary.words)
            {
                Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
            }
        }

        public void Translate(/*Dictionary<string, string> dict*/)
        {
            string input = Console.ReadLine();
            int first = input.IndexOf(@"\$");
            int second = input.IndexOf(@"\$");


            string splitInput = input.Substring(first, second - first+12);

            Console.WriteLine(splitInput);
            //foreach (string word in splitInput)
            //{
            //    Console.WriteLine(word);
            //}
        }
    }

    class Dictionary
    {
        public Dictionary<string, string> words = new Dictionary<string, string>();

        public Dictionary<string, string> AddWords(string key, string value)
        {
            words.Add(key, value);
            return words;
        }
    }
}
