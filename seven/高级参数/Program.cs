using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 高级参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //out参数
            //写一个方法，求一个数组中的最大值，最小值，总和，平均值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //将要返回的4个值放到一个数组中返回
            //int[] res = GetMaxMinSumAvg(numbers);
            int max1;
            int min1;
            int sum1;
            int avg1;
            Test(numbers, out max1, out min1, out sum1, out avg1);
            Console.WriteLine("最大值是{0}最小值是{1}总和是{2}平均值是{3}", max1,min1,sum1,avg1);
            Console.ReadKey();

            //问题 这个方法只能全部返回int类型 不能返回多种类型
        }
        /// <summary>
        /// 计算一整数数组的最大值，最小值，平均值，总和
        /// </summary>
        /// <param name="nums">要求的数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>

        public static void Test(int[] nums,out int max,out int min,out int sum,out int avg)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
                if (nums[i]<min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
        /// <summary>
        /// 计算一个数组的最大值，最小值，总和，平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假设 res[0]存的是最大值 res[1]存的是最小值 res[2]总和 res[3]平均值
            //int max = nums[0];
            //int min = nums[1];
            res[0] = nums[0];
            res[1] = nums[0];
            res[2] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                //如果当前循环到的元素比我假定的最大值还大 则
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }
    }
}
