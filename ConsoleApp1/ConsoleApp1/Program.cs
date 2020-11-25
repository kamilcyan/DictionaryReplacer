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
            prog.Translate(prog.WriteIn());

            Console.ReadLine();
        }

        public Dictionary<string, string> WriteIn()
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

            return dictionary.words;
        }

        public void Translate(Dictionary<string, string> dict)
        {
            string input = Console.ReadLine();

            char sear2 = '\\';
            string[] source = input.Split('$');
            string[] wordsForDict = new string[source.Length - 1];

            for (int i = 0; i < source.Length - 1; i++)
            {
                if (source[i][source[i].Length - 1] == sear2)
                {
                    wordsForDict[i] = source[i].Substring(0, source[i].Length - 1);
                }
                else
                {
                    wordsForDict[i] = source[i];
                }
            }

            for (int i = 0; i < wordsForDict.Length; i++)
            {
                if (dict.ContainsKey(wordsForDict[i]))
                {
                    Console.Write(dict[wordsForDict[i]]);
                }
                else
                {
                    Console.Write(wordsForDict[i]);
                }
            }
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
