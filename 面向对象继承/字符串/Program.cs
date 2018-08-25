using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "张三";
            //string s2 = "张三";
            //string s3 = "12345";
            ////既然可以将string看作char类型的只读数组,所以我们可以通过下标访问字符串中的某一个元素
            //Console.WriteLine(s3[0]);
            ////想实现既可读又可写 首先将字符串转换为char类型的数组
            //char[] chs=s3.ToCharArray();
            //chs[0] = 'b' ;
            ////将字符数组转换为我们的字符串
            //s3 = new string(chs);
            //Console.WriteLine(s3);

            //string str = null;
            //创建了一个计时器,用来记录程序运行的时间
            StringBuilder sb = new StringBuilder();//在内存中没有开空间
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                //str += i;//每次都要开空间 很浪费时间
                sb.Append(i);
            }
            sw.Stop();
            //一切类型都可以调用ToString()方法转换成字符串类型
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
