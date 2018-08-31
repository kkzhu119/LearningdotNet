using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //object o = n;//装箱
            //int nn = (int)o;//拆箱

            //这个循环发生了10000000次装箱操作
            //ArrayList list = new ArrayList(); //00:00:01.3259075
            //List<int> list = new List<int>();     //00:00:00.1057509
            ////这里没有装箱 会快很多 代码中应该尽量避免装箱和拆箱
            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //然而这里并没有发生任意类型的装箱和拆箱 这俩种类型没有继承关系
            //string str = "123";
            //int n = Convert.ToInt32(str);
            int n = 10;
            IComparable i = n;  //发生了装箱 有继承关系 接口也属于引用类型 值类型到引用类型



            Console.ReadKey();
        }
    }
}
