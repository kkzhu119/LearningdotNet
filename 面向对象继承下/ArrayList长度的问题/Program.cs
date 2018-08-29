using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList长度的问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //count 表示这个集合中实际包含的元素的个数
            //capcity 表示这个集合中可以包含的元素的个数
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.Add(1);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);

            Console.ReadKey();
        }
    }
}
