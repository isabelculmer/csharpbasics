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
          
            List<int> nums = new List<int>() { 1, 2, 3, 4, 2, 4, 7, 2, 8 };

            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        Console.WriteLine(nums[i]);
                    }
                }
            }

        }
       
        
    }
}
