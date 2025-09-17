using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World");
            string name;
            int number;
            int number2;
            number = 6;
            number2 = 9;

            int answer;
            answer = number + number2;


            Console.WriteLine("What is your age");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine(number);
            Console.ReadKey();

        }
    }
}
