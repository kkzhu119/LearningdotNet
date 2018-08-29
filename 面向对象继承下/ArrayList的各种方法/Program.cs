using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(true);
            list.Add(1);
            list.Add("张三");
            //添加集合元素用AddRange
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            list.AddRange(list);
            //list.Clear(); 清空所有元素
            //list.Remove(true);  删除单个元素 写谁删谁
            //list.RemoveAt(0); 根据下标去删除元素
            //list.RemoveRange(0, 3); 根据下标移除一定范围内的元素
            //list.Sort(); //要保证能排序 
            //list.Reverse();  //翻转
            //list.Insert(2, 2);
            //list.InsertRange(2, new int[] { 22, 2, 3, 333, 4 });
           //bool b = list.Contains(1);
           // Console.WriteLine(b);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
