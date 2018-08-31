using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace 文件流下
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用streamReader来读取一个文本文件
            using(StreamReader sr = new StreamReader(@"X:\test.txt",Encoding.Default))
            {
                //Console.WriteLine(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            //使用streamWriter写入一个文本文件
            using(StreamWriter sw = new StreamWriter(@"X:\test1111.txt",true))
            {
                sw.Write("把你覆盖掉");

            }

            Console.WriteLine("写入完成");
            Console.ReadKey();
        }
    }
}
