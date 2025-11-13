using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddTwo(5,6));
            Console.WriteLine(Biggest(5,6));
            Console.WriteLine(isOdd(4));
        }
        static bool isOdd(int x)
        {
            if (x % 2 == 1)
            { 
                return true;    
            }
            return false;
        }
        static int Biggest(int a, int b)
        {
            if (a > b)
            { 
                return a;
            }
            return b;
        }
        static int AddTwo(int a, int b)
        {
            int result = a + b;
            return result;
        }


        static int Listtotal(List<int> list)
        {
            int total = 0;
            foreach (int item in list)
            {
                total += item;
            }
            return total;
        }

        static bool checkeven(int n)
        {
            if (n % 2 == 0)
            { 
                return true;
            }
            return false;
        }


        static double converttokilo(double miles)
        {
            double result = 0;
            result = miles * 1.6;
            return result;
        }

    }
}
