using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
