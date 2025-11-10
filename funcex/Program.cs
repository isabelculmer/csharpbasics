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
           // double kilo = 0;
           // kilo =  ;

            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            Console.WriteLine(Listtotal(l));
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
