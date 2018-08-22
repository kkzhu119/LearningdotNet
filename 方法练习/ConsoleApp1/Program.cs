using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：写一个方法，将字符串数组{"中国","美国","巴西","澳大利亚","加拿大"}中的内容反转
            //string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Reverse(str);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //写一个方法，计算圆的面积和周长
            //double r = 5;
            //double perimeter;
            //double area;
            //GetPerimeterArea(r, out perimeter, out area);
            //Console.WriteLine("周长是{0}面积是{1}", perimeter, area);

            //计算任意多个数间的最大值
            //GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //int max = GetMax(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(max);
            //Console.ReadKey();

        }
        /// <summary>
        /// 求任意个数int型数字的最大值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }



        public static void GetPerimeterArea(double r,out double perimeter,out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }

        public static void Reverse(string[] str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                string temp = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - 1] = temp;
            }
        }
    }
}
