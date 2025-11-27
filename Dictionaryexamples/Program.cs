using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryexamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] myarray = new string[6];
            myarray[0] = "hello";

            //Dictionary - key values pairs
            //Dictionary<int, string> names = new Dictionary<int, string>();
            //names.Add(1, "Mario");
            //names.Add(2, "Luigi");

            //foreach (KeyValuePair<int, string> item in names)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}


            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("UK", "London");
            map.Add("France", "Paris");
            map.Add("Italy", "Rome");

            Console.WriteLine("Enter country");
            string answer = Console.ReadLine();

            Console.WriteLine(map[answer]);



            Console.ReadKey();





            //example why we use it
            Dictionary<char, int> countchars = new Dictionary<char, int>();
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if ("aeiou".Contains(word[i])) //check if vowel
                {
                    if (countchars.ContainsKey(word[i]))  //already seen vowel before
                    {
                        countchars[word[i]]++;
                    }
                    else //not see, so add to dictionary 
                    {
                        countchars.Add(word[i], 1);
                    }
                }
            }

            foreach (KeyValuePair<char, int> item in countchars)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }











        }
    }
}
