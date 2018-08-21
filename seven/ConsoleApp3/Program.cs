using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，判断一个年份是否是闰年
            //Console.WriteLine(isRunYear(1000));
            //Console.WriteLine(GetMax(100, 200));
            //Console.ReadKey();
            #region 练习1
            //Console.WriteLine("请输入一个数字");
            //string input = Console.ReadLine();
            //int number = GetNumber(input);
            //Console.WriteLine(number);
            //Console.ReadKey();
            #endregion

            #region 练习2
            //练习：只能让用户输入yes或no，只要不是，就重新输入

            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string result = IsYesOrNo(str);
            //Console.WriteLine(result);
            //Console.ReadKey();
            #endregion
            //计算输入数组的和
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 一个整数类型数组的总和
        /// </summary>
        /// <param name="numbers">要求总和的数组</param>
        /// <returns>返回这个数组的总和</returns>
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        /// <summary>
        /// 限定用户只能输入yes或者no,并且返回
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYesOrNo(string input)
        {
            while (true)
            {
                if(input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no 请重新输入!");
                    input = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 这个方法需要判断用户的输入是否是数字
        /// 如果是数字，则返回
        /// 如果不是数字，提示用户重新输入
        /// </summary>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
               
            }
        }

        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool isRunYear(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
        /// <summary>
        /// 计算两个整数之间的最大值，并且返回最大值
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int GetMax(int n1,int n2)
        {
           int max =  n1 > n2 ? n1 : n2;
            return max;
        }
    }
}
