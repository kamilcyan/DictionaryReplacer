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
            //Dictionary dictionary = new Dictionary();

            //dictionary.AddWords("temp", "temporary");
            //dictionary.AddWords("adj", "adjustment");
            //dictionary.AddWords("go", "gorilla");
            //dictionary.AddWords("name", "John Wick");
            //dictionary.AddWords("op", "open");
            //dictionary.AddWords("plax", "please");
            //dictionary.AddWords("prog", "DictionaryReplacer");
            //dictionary.AddWords("goal", "Work");
            //dictionary.AddWords("res", "resistance");
            //dictionary.AddWords("nud", "send nudes");

            //foreach (KeyValuePair<string, string> kvp in dictionary.words)
            //{
            //    Console.WriteLine("{0}, {1}", kvp.Key, kvp.Value);
            //}
        }

        public void Translate(/*Dictionary<string, string> dict*/)
        {
            string input = Console.ReadLine();

            string searched = @"\$";
            char sear2 = '\\';
            string[] source = input.Split('$');


            for(int i = 1; i < source.Length-1; i++)
            {
                if(source[i][source[i].Length-1] == sear2)
                {
                    Console.WriteLine(source[i].Substring(0, source[i].Length - 1));
                }

            }




            //int first = input.IndexOf(@"\$");
            //int second = input.IndexOf(@"\$");

            //int[] found = new int[input.Length];

            //for(int i = 0; i< input.Length; i++)
            //{
            //    //found[i] = 0;
            //    found[i] = input.IndexOf(@"\$");

            //}

            //for(int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(input.Substring(found[i] + 2));
            //}

            //Console.WriteLine(" {0}", input.Substring(found +2));
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
