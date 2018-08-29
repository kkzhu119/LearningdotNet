using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个键值对集合对象
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht[6] = "新来的";//这也是一种添加数据的方式
            //在键值对集合中，是根据键去找值的
            ht[1] = "把张三干掉";//这样添加数据会把张三干掉 不会报异常
            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经包含abc这个键");
            }
            //ht.Clear();
            
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[false]);
            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}
            //foreach (var item in ht)
            //{
            //    //Console.WriteLine(item);//只打印命名空间

            //}
            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in ht.Keys)
            {
                //Console.WriteLine(item);
                Console.WriteLine(ht[item]);
            }
            Console.ReadKey();
        }
    }
}
