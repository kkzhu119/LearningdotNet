using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //属于类的字段
        public static int _number = 10;  //使用静态字段来模拟全局变量

        static void Main(string[] args)
        {

            //int b = 10;
            //int a = 3;
            Test();
            Console.WriteLine(_number);
            Console.ReadKey();
        }

        public static void Test()
        {
            _number++;
            Console.WriteLine(_number);
        }
        
    }
}
