using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structuresex
{
    internal class Program
    {
        struct TestResult
        {
            public string name;
            public int score;
        }

        static void Main(string[] args)
        {
            TestResult[] CAP1 = new TestResult[5];

            Console.WriteLine("Enter 5 student results for CAP1:");
            for (int i = 0; i < 5; i++)
            {
                TestResult temp;
                Console.WriteLine($"Enter the name for student {i + 1}.");
                temp.name = Console.ReadLine();
                Console.WriteLine($"Enter the score for {temp.name}");
                temp.score = int.Parse(Console.ReadLine());
                CAP1[i] = temp;
            }
            int num1 = 0;
            int num2 = 0;
            foreach (TestResult student in CAP1)
            {
                num1 += student.score;
                if (num2 < student.score) num2 = student.score;
            }
            Console.WriteLine("Test statistics for CAP1:");
            Console.WriteLine($"TOP: {num2}, AVG: {num1 / 5.0}");

        }
    }
}
