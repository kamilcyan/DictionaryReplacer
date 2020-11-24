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
            Dictionary dictionary = new Dictionary();

            dictionary.AddWords("temp", "temporary");

            foreach (KeyValuePair<string, string> kvp in dictionary.words)
            {
                Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
            }


            Console.ReadLine();
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
