using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList和HashTable
            //创建了一个集合对象
            ArrayList list = new ArrayList();
            Person P = new Person();
            //集合：很多数据的一个集合
            //数组：长度不可变、类型单一
            //集合的好处：长度可以任意改变，类型随便
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add('男');
            list.Add(5000m);
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            list.Add(P);
            list.Add(list);
            
            for (int i = 0; i < list.Count; i++)
            {
                //list[i]是object类型 和person存在继承关系
                if(list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                }else if(list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);
                    }
                }
                else
                {
                    Console.WriteLine(list[i]);
                }
                //Console.WriteLine(list[i]);
            }
            //我们将一个对象输出到控制台，默认情况下打印的就是这个对象所在的类的命名空间
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine(nums.ToString());
            Console.ReadKey();
           
        }
        public class Person
        {
            public void SayHello()
            {
                Console.WriteLine("我是人类");
            }
        }
    }
}
