using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //    double salary = 5000;
            //    JiangJin(ref salary);
            //    Console.WriteLine(salary);
            //    Console.ReadKey();
            //使用方法来交换两个int类型的变量

            int nn1 = 10;
            int nn2 = 20;
            Test(ref nn1, ref nn2);
            Console.WriteLine("nn1:{0},nn2:{1}",nn1,nn2);
            Console.ReadKey();

        }
        public static void Test(ref int n1,ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
        public static void JiangJin(ref double s)
        {
            s += 500;
        }

        public static void FaKuan(double s)
        {
            s += 500;
        }
    }
}
