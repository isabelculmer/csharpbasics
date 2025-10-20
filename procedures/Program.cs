using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procedures
{
    internal class Program
    {
      
        public static void Main()
        {
            string username = "";
            username = GenerateUsername("Isabel", "Culmer", 2000);
            Console.WriteLine(username);
            Console.ReadKey();
        }


        static string GenerateUsername(string fname, string lname, int birthyear)
        { 
            string firstletter = fname.Substring(0,1);
            string username = "xX_" + firstletter+lname+birthyear.ToString()+"_Xx"; ;
            return username;
        }






    }
}
