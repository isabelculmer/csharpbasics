using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_teaching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();

            mylist.Add(1);
            mylist.Add(-2);
            mylist.Add(3);

            mylist.Remove(1);
            mylist.RemoveAt(0);
            Example2();

        }
        static void Example0()//initialising
        {
            List<string> names = new List<string>();
            names.Add("Holly");
            names.Add("Anika");

            List<string> names2 = new List<string>() { "Holly", "Anika" };

            List<string> names3 = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                names3.Add(Console.ReadLine());
            }
            Display(names);
        }
        static void Example1()//split
        {
            string sentence = "Hello World My Old Friend";
            string[] split = sentence.Split(' ');
            List<string> words = new List<string>(split);
            //or
            List<string> words2 = new List<string>();
            foreach (string word in split)
            {
                words2.Add(word);
            }
            Display(words);
        }
        static void Example2()//removing things from a list
        {
            List<int> nums = new List<int>() { 1, 4, 2, 2, 5, 6 };
            Display(nums);
            nums.Remove(2);//removes the first instance of the 2 only
            Console.WriteLine();
            Display(nums);
            nums.RemoveAt(nums.Count - 1);// removes the last thing only
            Display(nums);
        }
        static void Example3()
        {
            Random random = new Random();
            List<int> nums = new List<int>() { 1, 3, 2, 6 };
            //for (int i = 0; i < nums.Count; i++)//this is a BAD way of doing it. don't want to remove items while you are iterating over the list using a for loop
            //{
            //    int index = random.Next(nums.Count);
            //    Console.WriteLine($"Deleting {nums[index]} at {index}");
            //    nums.RemoveAt(index);
            //}
            Display(nums);
            while (nums.Count > 0)//much better
            {
                int index = random.Next(nums.Count);
                Console.WriteLine($"Deleting {nums[index]} at {index}");
                nums.RemoveAt(index);
            }

        }
        static void Display<T>(List<T> list)//Ignore this. We will explain this much later.
        {
            foreach (T item in list)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
