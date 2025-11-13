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
            //string contents = File.ReadAllText(fileName);           

            //Console.WriteLine(contents);

            //int count = 0;
            //string[] lotsofcontent = File.ReadAllLines(fileName);
            //foreach (string line in lotsofcontent)
            //{
            //    count++;
            //    Console.WriteLine(count + " " + line);
            //}

            //string stufftostore = "bubbly boo";
            //File.WriteAllText("another.txt", stufftostore);

            //string[] names = { "Legolas", "Arwen" };
            //File.WriteAllLines("another.txt", names);

            //List<string> morenames = new List<string>() {"Frodo", "Sam" };
            //File.WriteAllLines("another.txt", morenames);

            List<string> evenmorenames = new List<string>();
            evenmorenames = new List<string>(File.ReadAllLines(fileName));
            evenmorenames.Sort();
            File.WriteAllLines("another.txt", evenmorenames);


        }
    }
}

