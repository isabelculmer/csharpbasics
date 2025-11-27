using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace textfiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            string fileName = "mytext.txt";

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                sw.Write("Another Pengiun");
            }

            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line.Length > 6)
                    {
                        Console.WriteLine(line);
                    }
                }
            }


      


        }
    }
}

