using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {

            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] {4,5,6,7,8,9});
            list.AddRange(list);
            //list.Reverse();
            //List泛型集合可以转换为数组
            //list.ToArray();返回值根据集合类型而定
            //数组也可以转换为集合
            int[] nums = list.ToArray();


            List<int> listTwo = nums.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}
