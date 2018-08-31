using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File类的读写方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.ReadAllLines(@"")  返回一个string类型的数组 按行来读取
            //File.ReadAllText(@"")  //返回一个string
            //File.ReadAllBytes()  //任何类型文件都可以读取
            File.WriteAllLines(@"X:\writealllinestest.txt",new string[] { "aoe","ewu"});
            Console.WriteLine("OK");
            File.WriteAllText(@"X:\writeallTexttest.txt", "你好");
            Console.WriteLine("OK");
            File.AppendAllText(@"X:\writeallTexttest.txt","我是追加的");
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
