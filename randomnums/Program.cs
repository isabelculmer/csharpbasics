using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                Console.BackgroundColor = (ConsoleColor)rnd.Next(0, 16);
                Console.Write(" ");
            }


      

        }
    }
}
