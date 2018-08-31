using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边，偶数显示在右边
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}
            ////List<int> listsum = new List<int>();
            ////listsum.AddRange(listOu);
            ////listsum.AddRange(listJi);
            ////listOu.AddRange(listJi);
            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.Write(item+"  ");
            //}
            //Console.ReadKey();

            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();


            //统计Welcome To China每个字符出现的次数，不考虑大小写
            string str = "Welcome to China";
            //当我找到这个字符时，就应该找到这个字符出现的次数

            Dictionary<char, int> dic = new Dictionary<char, int>();

            string ss = str.ToUpper();
            for (int i = 0; i < ss.Length; i++)
            {

                if (ss[i]==' ')
                {
                    continue;
                }
                //如果dic已经包含了当前循环到的这个键 
                if (dic.ContainsKey(ss[i]))
                {
                    //值再次加一
                    dic[ss[i]]++;
                }
                else
                {
                    //这个字符在集合当中是第一次出现
                    dic[ss[i]] = 1;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            }
            Console.ReadKey();
            


        }
    }
}
